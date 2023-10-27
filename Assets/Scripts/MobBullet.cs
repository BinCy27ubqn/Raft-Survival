using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobBullet : MonoBehaviour
{
    [SerializeField]
    private float _dealDamage;
    [SerializeField]
    private float _speedBullet;

    private Rigidbody _rigidbody;

    private void Start()
    {
        _rigidbody = gameObject.GetComponent<Rigidbody>();
        _rigidbody.velocity = transform.forward * _speedBullet;
        Destroy(gameObject, 4f);
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("ShipModule"))
        {
            PlayerHealth playerHealth = other.GetComponent<PlayerHealth>();
            if(playerHealth != null)
            {
                playerHealth.TakeDamage(_dealDamage);
                Destroy(gameObject);
            }
            ThrusterHealth thrusterHealth = other.GetComponent<ThrusterHealth>();
            if(thrusterHealth != null)
            {
                thrusterHealth.TakeDamage(_dealDamage);
                Destroy(gameObject);
            }
            HealthModuleHealth healthModuleHealth = other.GetComponent<HealthModuleHealth>();
            if(healthModuleHealth != null)
            {
                healthModuleHealth.TakeDamage(_dealDamage);
                Destroy(gameObject);
            }
            DamageHealth damageHealth = other.GetComponent<DamageHealth>();
            if(damageHealth != null)
            {
                damageHealth.TakeDamage(_dealDamage);
                Destroy(gameObject);
            }
            LightingHealth lightingHealth = other.GetComponent<LightingHealth>();
            if(lightingHealth != null)
            {
                lightingHealth.TakeDamage(_dealDamage);
                Destroy(gameObject);
            }
        }

        if (other.gameObject.CompareTag("Guard"))
        {
            Destroy(gameObject);
        }
    }
}
