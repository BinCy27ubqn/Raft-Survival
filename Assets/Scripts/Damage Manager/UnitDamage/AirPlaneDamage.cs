using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AirPlaneDamage : MonoBehaviour
{
    private float _timeInterval;
    [SerializeField]
    private GameObject _damageUI;
    [SerializeField]
    private GameObject _damageUIBoss;

    [SerializeField]
    private CheckLevelDamgeAirUnit _checkLevelDamgeAirUnit;

    private void Start()
    {
        _timeInterval = Time.time;
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy") && Time.time - _timeInterval > 0.15f)
        {
            EnemyHealth dealDamageForEnemy = other.GetComponent<EnemyHealth>();
            dealDamageForEnemy.TakeDamage(DamageManager.AirPlaneDamage()*_checkLevelDamgeAirUnit.ecreaseDamage*DamageUnit.damageIncreaseByAttckUnit * DamageManager._buffDamageByUpgradeShop * DamageManager._buffDamageByLevelTankAirport);

            GameObject takeDamageUI = Instantiate(_damageUI, other.transform.position + new Vector3(0, 2f, 0), _damageUI.transform.rotation);
            Destroy(takeDamageUI, 1f);
            _timeInterval = Time.time;
        }
        if (other.CompareTag("Boss") && Time.time - _timeInterval > 0.15f)
        {
            BossHealth dealDamageForBoss = other.GetComponent<BossHealth>();
            dealDamageForBoss.TakeDamage(DamageManager.AirPlaneDamage()*_checkLevelDamgeAirUnit.ecreaseDamage*DamageUnit.damageIncreaseByAttckUnit * DamageManager._buffDamageByUpgradeShop * DamageManager._buffDamageByLevelTankAirport);

            GameObject takeDamageUI = Instantiate(_damageUIBoss, other.transform.position + new Vector3(0, 1.5f, 0), _damageUI.transform.rotation);
            Destroy(takeDamageUI, 0.5f);
            _timeInterval = Time.time;
        }

    }
}
