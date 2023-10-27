using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionBullet : MonoBehaviour
{
    [SerializeField]
    private float _explosionRadius;
    [SerializeField]
    private int _explosionDamage;

    [SerializeField]
    private GameObject _particleSystem;

    [SerializeField]
    private float _speed;
    [SerializeField]
    private float _lifeTime;

    [SerializeField]
    private CheckLevelDamgeTank _checkLevelDamgeTank;
    [SerializeField]
    private GameObject _damageUI;
    [SerializeField]
    private GameObject _damageUIBoss;
    private void Start()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        rb.velocity = transform.forward * _speed;

        Destroy(gameObject, _lifeTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy") || other.CompareTag("Boss"))
        {
            BlowObjects();
            Instantiate(_particleSystem,transform.position, transform.rotation);
            _particleSystem.SetActive(true);
            Destroy(gameObject);
        }

        if(other.gameObject.name == "Salmon(Clone)"){
            Vector3 direction =  - transform.position + other.transform.position;
            direction.y = 0;

            Vector3 newPosition = other.transform.position + direction * 0.8f;
            other.transform.position = newPosition;
        }
    }

    public void BlowObjects()
    {
        Collider[] affectedBlow = Physics.OverlapSphere(transform.position, _explosionRadius);
        foreach(Collider col in affectedBlow)
        {
            if (col.gameObject.CompareTag("Enemy"))
            {
                EnemyHealth enemyHealth = col.GetComponent<EnemyHealth>();
                if(enemyHealth != null)
                {
                    enemyHealth.TakeDamage(DamageManager.TankBulletDamage() * _checkLevelDamgeTank.ecreaseDamage * DamageUnit.damageIncreaseByAttckUnit * DamageManager._buffDamageByUpgradeShop * DamageManager._buffDamageByLevelTankUnit);
                    GameObject takeDamageUI = Instantiate(_damageUI, col.transform.position + new Vector3(0, 2f, 0), _damageUI.transform.rotation);
                    Destroy(takeDamageUI, 1f);
                }
            }
            if (col.gameObject.CompareTag("Boss"))
            {
                BossHealth bossHealth = col.GetComponent<BossHealth>();
                if(bossHealth != null)
                {
                    bossHealth.TakeDamage(DamageManager.TankBulletDamage() * _checkLevelDamgeTank.ecreaseDamage * DamageUnit.damageIncreaseByAttckUnit * DamageManager._buffDamageByUpgradeShop * DamageManager._buffDamageByLevelTankUnit);
                    GameObject takeDamageUI = Instantiate(_damageUIBoss, col.transform.position + new Vector3(0, 1.5f, 0), _damageUIBoss.transform.rotation);
                    Destroy(takeDamageUI, 0.5f);
                }
            }
        }
    }

    public void DestroyParticalSystem()
    {
        Destroy(_particleSystem);
    }
}
