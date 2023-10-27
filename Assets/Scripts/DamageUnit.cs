using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageUnit : MonoBehaviour
{
    private PlayerMovement _playerMovement;
    [SerializeField]
    private DamageLevelUp _damageLevelUp;
    public static float ecreaseDamage = 0;
    private float ecreaseDamagePercent = 1.1f;

    public static float damageIncreaseByAttckUnit = 1;

    void Start()
    {

        float damageWereIncrease = damageIncreaseByAttckUnit * ecreaseDamagePercent;
        ecreaseDamage = damageWereIncrease - damageIncreaseByAttckUnit;
        damageIncreaseByAttckUnit = damageWereIncrease;
    }

    private void Update()
    {
        if (DamageHealth.damageIsDie == true)
        {
            damageIncreaseByAttckUnit = 1f /*damageIncreaseByAttckUnit - ecreaseDamage - DamageLevelUp.ecreaseDamage*/;
            DamageHealth.damageIsDie = false;
        }
    }
}
