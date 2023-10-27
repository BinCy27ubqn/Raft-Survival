using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretBullet : MonoBehaviour
{
    private GameObject enemy;
    private bool _detection = true;

    [SerializeField]
    private float _speedBullet;

    private Rigidbody _rigidbody;

    [SerializeField]
    private CheckLevelDamageTurret _checkLevelDamageTurret;
    [SerializeField]
    private GameObject _damageUI;
    [SerializeField]
    private GameObject _damageUIBoss;
    private void Start()
    {
        _rigidbody = gameObject.GetComponent<Rigidbody>();
        _rigidbody.velocity = transform.forward * _speedBullet;

        Destroy(gameObject, 2.4f);
    }

    private void Update()
    {
        //FindClosestEnemy();
    }

    public void FindClosestEnemy()
    {
        if (_detection == true)
        {
            GameObject player = GameObject.Find("ShootPoint");

            float distanceTocloseEnemy = Mathf.Infinity;
            EnemyMovement closestEnemies = null;
            EnemyMovement[] allEnenies = GameObject.FindObjectsOfType<EnemyMovement>();
            foreach (EnemyMovement currentEnemy in allEnenies)
            {
                float distanceToEnemy = (currentEnemy.transform.position - player.transform.position).magnitude;
                if (distanceToEnemy < distanceTocloseEnemy)
                {
                    distanceTocloseEnemy = distanceToEnemy;
                    closestEnemies = currentEnemy;
                }
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            EnemyHealth dealDamageForEnemy = other.GetComponent<EnemyHealth>();
            dealDamageForEnemy.TakeDamage(DamageManager.TurretBulletDamage() * _checkLevelDamageTurret.ecreaseDamage * DamageUnit.damageIncreaseByAttckUnit * DamageManager._buffDamageByUpgradeShop * DamageManager._buffDamageByLevelTurretUnit);
            GameObject takeDamageUI = Instantiate(_damageUI, other.transform.position + new Vector3(0, 2f, 0), _damageUI.transform.rotation);
            Destroy(takeDamageUI, 1f);
        }

        if (other.gameObject.CompareTag("Enemy"))
        {
            Destroy(gameObject);
            _detection = false;

        }
        
        if (other.gameObject.CompareTag("Boss"))
        {
            BossHealth dealDamageForBoss = other.GetComponent<BossHealth>();
            dealDamageForBoss.TakeDamage(DamageManager.TurretBulletDamage() * _checkLevelDamageTurret.ecreaseDamage * DamageUnit.damageIncreaseByAttckUnit * DamageManager._buffDamageByUpgradeShop * DamageManager._buffDamageByLevelTurretUnit);
            GameObject takeDamageUI = Instantiate(_damageUIBoss, other.transform.position + new Vector3(0, 1.5f, 0), _damageUI.transform.rotation);
            Destroy(takeDamageUI, 0.5f);
        }

        if (other.gameObject.CompareTag("Boss"))
        {
            Destroy(gameObject);
            _detection = false;

        }
    }
}
