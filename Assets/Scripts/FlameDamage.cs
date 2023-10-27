using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlameDamage : MonoBehaviour
{
    private float _timeInterval;
    [SerializeField]
    private GameObject _damageUI;
    [SerializeField]
    private GameObject _damageUIBoss;
    GameObject boss;

    private void Start()
    {
        _timeInterval = Time.time;
        
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy") && Time.time - _timeInterval > 0.2f)
        {
            EnemyHealth dealDamageForEnemy = other.GetComponent<EnemyHealth>();
            dealDamageForEnemy.TakeDamage(DamageManager.FlameDamage() * DamageUnit.damageIncreaseByAttckUnit * DamageManager._buffDamageByUpgradeShop);

            GameObject takeDamageUI = Instantiate(_damageUI, other.transform.position + new Vector3(0, 3f, 0), _damageUI.transform.rotation);
            Destroy(takeDamageUI, 2f);
            _timeInterval = Time.time;
        }

        if (other.gameObject.CompareTag("Boss") && Time.time - _timeInterval > 0.2f)
        {
            Debug.Log("abc");
            BossHealth dealDamageForBoss = other.GetComponent<BossHealth>();
            dealDamageForBoss.TakeDamage(DamageManager.FlameDamage() * DamageUnit.damageIncreaseByAttckUnit * DamageManager._buffDamageByUpgradeShop);

            GameObject takeDamageUI = Instantiate(_damageUIBoss, other.transform.position + new Vector3(0, 1.5f, 0), _damageUIBoss.transform.rotation);
            Destroy(takeDamageUI, 0.5f);
            _timeInterval = Time.time;
        }

    }
}
