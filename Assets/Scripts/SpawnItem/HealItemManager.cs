using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealItemManager : MonoBehaviour
{
    [SerializeField]
    private float _amountHealing;

    [SerializeField]
    private GameObject _healthItem;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("ShipModule"))
        {
            GameObject UIHealth = Instantiate(_healthItem, gameObject.transform.position, _healthItem.transform.rotation);
            Destroy(UIHealth, 1f);

            PlayerHealth[] playerHealths = GameObject.FindObjectsOfType<PlayerHealth>();
            DamageHealth[] damageHealths = GameObject.FindObjectsOfType<DamageHealth>();
            ThrusterHealth[] thrusterHealths = GameObject.FindObjectsOfType<ThrusterHealth>();
            HealthModuleHealth[] healthModuleHealths = GameObject.FindObjectsOfType<HealthModuleHealth>();
            LightingHealth[] lightingHealths = GameObject.FindObjectsOfType<LightingHealth>();

            foreach(var health in playerHealths)
            {
                health._currentHealth += _amountHealing;
                if(health._currentHealth > health._health)
                {
                    health._currentHealth = health._health;
                }
                health.ShowHealthBar();
            }
            foreach(var health in damageHealths)
            {
                health._currentHealth += _amountHealing;
                if(health._currentHealth > health._health)
                {
                    health._currentHealth = health._health;
                }
                health.ShowHealthBar();
            }
            foreach(var health in thrusterHealths)
            {
                health._currentHealth += _amountHealing;
                if(health._currentHealth > health._health)
                {
                    health._currentHealth = health._health;
                }
                health.ShowHealthBar();
            }
            foreach(var health in healthModuleHealths)
            {
                health._currentHealth += _amountHealing;
                if(health._currentHealth > health._health)
                {
                    health._currentHealth = health._health;
                }
                health.ShowHealthBar();
            }
            foreach(var health in lightingHealths)
            {
                health._currentHealth += _amountHealing;
                if(health._currentHealth > health._health)
                {
                    health._currentHealth = health._health;
                }
                health.ShowHealthBar();
            }

            Destroy(gameObject);
        }
    }
}
