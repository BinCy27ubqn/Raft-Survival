using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealingFromTree : MonoBehaviour
{
    [SerializeField]
    private float _quantityHealing;


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("ShipModule"))
        {
            PlayerHealth[] playerHealths = GameObject.FindObjectsOfType<PlayerHealth>();
            foreach(var playerHealth in playerHealths)
            {
                if(playerHealth != null)
                {
                    playerHealth._currentHealth += _quantityHealing;
                    if (playerHealth._currentHealth >= playerHealth._health)
                    {
                        playerHealth._currentHealth = playerHealth._health;
                    }
                    
                    if(playerHealth._currentHealth < playerHealth._health)
                    {
                        playerHealth.ShowHealthBar();
                    }
                }
            }
            
            DamageHealth[] damageHealths = GameObject.FindObjectsOfType<DamageHealth>();
            foreach(var damageHealth in damageHealths)
            {
                if(damageHealth != null)
                {
                    damageHealth._currentHealth += _quantityHealing;
                    if (damageHealth._currentHealth >= damageHealth._health)
                    {
                        damageHealth._currentHealth = damageHealth._health;
                    }
                    
                    if (damageHealth._currentHealth < damageHealth._health)
                    {
                        damageHealth.ShowHealthBar();
                    }
                }
            }
            
            LightingHealth[] lightingHealths = GameObject.FindObjectsOfType<LightingHealth>();
            foreach(var lightingHealth in lightingHealths)
            {
                if(lightingHealth != null)
                {
                    lightingHealth._currentHealth += _quantityHealing;
                    if (lightingHealth._currentHealth >= lightingHealth._health)
                    {
                        lightingHealth._currentHealth = lightingHealth._health;
                    }
                    
                    if (lightingHealth._currentHealth < lightingHealth._health)
                    {
                        lightingHealth.ShowHealthBar();
                    }
                }
            }
            
            HealthModuleHealth[] healthModuleHealths = GameObject.FindObjectsOfType<HealthModuleHealth>();
            foreach(var healthModuleHealth in healthModuleHealths)
            {
                if(healthModuleHealth != null)
                {
                    healthModuleHealth._currentHealth += _quantityHealing;
                    if (healthModuleHealth._currentHealth >= healthModuleHealth._health)
                    {
                        healthModuleHealth._currentHealth = healthModuleHealth._health;
                    }
                    
                    if (healthModuleHealth._currentHealth < healthModuleHealth._health)
                    {
                        healthModuleHealth.ShowHealthBar();
                    }
                }
            }
            
            ThrusterHealth[] thrusterHealths = GameObject.FindObjectsOfType<ThrusterHealth>();
            foreach(var thrusterHealth in thrusterHealths)
            {
                if(thrusterHealth != null)
                {
                    thrusterHealth._currentHealth += _quantityHealing;
                    if (thrusterHealth._currentHealth >= thrusterHealth._health)
                    {
                        thrusterHealth._currentHealth = thrusterHealth._health;
                    }
                    
                    if (thrusterHealth._currentHealth < thrusterHealth._health)
                    {
                        thrusterHealth.ShowHealthBar();
                    }
                }
            }
        }
    }
}
