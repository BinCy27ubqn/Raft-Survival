using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletShoot : MonoBehaviour
{
    private GameObject enemy;
    private bool _detection = true;

    [SerializeField]
    private float _speedBullet;

    private Rigidbody _rigidbody;

    private void Start()
    {
        _rigidbody = gameObject.GetComponent<Rigidbody>();
        _rigidbody.velocity = transform.forward * _speedBullet;

        Destroy(gameObject, 2.4f);
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
            dealDamageForEnemy.TakeDamage(DamageManager.DeafaultDamage()*DamageUnit.damageIncreaseByAttckUnit * DamageManager._buffDamageByUpgradeShop);
        }

        if (other.gameObject.CompareTag("Enemy"))
        {
            Destroy(gameObject);
            _detection = false;
        }
        if (other.gameObject.CompareTag("Boss"))
        {
            BossHealth dealDamageForEnemy = other.GetComponent<BossHealth>();
            dealDamageForEnemy.TakeDamage(DamageManager.DeafaultDamage()*DamageUnit.damageIncreaseByAttckUnit * DamageManager._buffDamageByUpgradeShop);
        }

        if (other.gameObject.CompareTag("Boss"))
        {
            Destroy(gameObject);
            _detection = false;
        }
    }
}