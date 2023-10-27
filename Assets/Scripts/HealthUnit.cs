using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthUnit : MonoBehaviour
{
    private PlayerMovement _playerMovement;
    [SerializeField]
    private HealthLevelUP _healthLevelUP;
    public static float ecreaseHealth = 0;
    private float ecreaseHealthPercent = 1.1f;

    public static float healthIncreaseByHealthUnit = 1;

    public static bool healthIsBuild;

    private float increaseHealth = 20;
    void Start()
    {
        HealthManager.isIncresaHealth = true;
        healthIsBuild = true;
        float healthWereIncrease = healthIncreaseByHealthUnit * ecreaseHealthPercent;
        ecreaseHealth = healthWereIncrease - healthIncreaseByHealthUnit;
        healthIncreaseByHealthUnit = healthWereIncrease;

        HealthManager.increaseHealth += increaseHealth;


    }

    private void Update()
    {
        if (HealthModuleHealth.healthIsDie == true)
        {
            HealthManager.increaseHealth = HealthManager.health; 
            healthIncreaseByHealthUnit = 1f;
            HealthModuleHealth.healthIsDie = false;
        }
    }
}
