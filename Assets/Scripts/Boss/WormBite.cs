using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WormBite : MonoBehaviour
{
    [SerializeField]
    private float _dealDamage;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("ShipModule"))
        {

            PlayerHealth playerHealth = other.gameObject.GetComponent<PlayerHealth>();
            if (playerHealth != null)
            {
                playerHealth.TakeDamage(_dealDamage);
            }
            ThrusterHealth thrusterHealth = other.gameObject.GetComponent<ThrusterHealth>();
            if (thrusterHealth != null)
            {
                thrusterHealth.TakeDamage(_dealDamage);
            }
            HealthModuleHealth healthModuleHealth = other.gameObject.GetComponent<HealthModuleHealth>();
            if (healthModuleHealth != null)
            {
                healthModuleHealth.TakeDamage(_dealDamage);
            }
            DamageHealth damageHealth = other.gameObject.GetComponent<DamageHealth>();
            if (damageHealth != null)
            {
                damageHealth.TakeDamage(_dealDamage);
            }
            LightingHealth lightingHealth = other.gameObject.GetComponent<LightingHealth>();
            if (lightingHealth != null)
            {
                lightingHealth.TakeDamage(_dealDamage);
            }
        }
    }
}
