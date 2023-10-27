using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageManager : MonoBehaviour
{
    public static int defaultBulletDamage = 10;
    public static int tankBulletDamage = 15;
    public static int flameDamage = 4;
    public static int airPlaneDamage = 5;
    public static int lightingDamage = 10;
    public static int turretBulletDamage = 5;
    public static int rocketTurretDamage = 11;

    public static int numberOfDamageUnit = 1;

    public static float increaseAirPlaneDamage;

    public static float _buffDamageByUpgradeShop;
    public static float _buffDamageByLevelTurretUnit;
    public static float _buffDamageByLevelTankUnit;
    public static float _buffDamageByLevelTankAirport;
    public static float _buffDamageByLevelRocketTurret;
    public static float _buffDamageByLevelForceField;

    private void Start()
    {
        if(PlayerPrefs.GetInt("DamageCurrentLevel") == 1)
        {
            _buffDamageByUpgradeShop = 1;
        }else if(PlayerPrefs.GetInt("DamageCurrentLevel") == 2)
        {
            _buffDamageByUpgradeShop = 1.5f;
        }else if(PlayerPrefs.GetInt("DamageCurrentLevel") == 3)
        {
            _buffDamageByUpgradeShop = 2f;
        }else if(PlayerPrefs.GetInt("DamageCurrentLevel") == 4)
        {
            _buffDamageByUpgradeShop = 3f;
        }

        BuffDamageByLevelTurret();
        BuffDamageByLevelTank();
        BuffDamageByLevelAirport();
        BuffDamageByLevelRocketTurret();
        BuffDamageByLevelForceField();
    }

    public static int DeafaultDamage()
    {
        return defaultBulletDamage;
    }
    public static int TurretBulletDamage()
    {
        return turretBulletDamage;
    }
    public static int TankBulletDamage()
    {
        return tankBulletDamage;
    }
    public static int FlameDamage()
    {
        return flameDamage;
    }
    public static float AirPlaneDamage()
    {
        return airPlaneDamage;
    }
    public static int LightingDamage()
    {
        return lightingDamage;
    }
    public static int RocketTurretDamage()
    {
        return rocketTurretDamage;
    }

    private void BuffDamageByLevelTurret()
    {
        if (PlayerPrefs.GetInt("LevelTurret") == 1)
        {
            _buffDamageByLevelTurretUnit = 1;
        }
        else if (PlayerPrefs.GetInt("LevelTurret") == 2)
        {
            _buffDamageByLevelTurretUnit = 1.25f;
        }
        else if (PlayerPrefs.GetInt("LevelTurret") == 3)
        {
            _buffDamageByLevelTurretUnit = 1.5f;
        }
        else if (PlayerPrefs.GetInt("LevelTurret") == 4)
        {
            _buffDamageByLevelTurretUnit = 2f;
        }
    }
    
    private void BuffDamageByLevelTank()
    {
        if (PlayerPrefs.GetInt("LevelTank") == 1)
        {
            _buffDamageByLevelTankUnit = 1;
        }
        else if (PlayerPrefs.GetInt("LevelTank") == 2)
        {
            _buffDamageByLevelTankUnit = 1.25f;
        }
        else if (PlayerPrefs.GetInt("LevelTank") == 3)
        {
            _buffDamageByLevelTankUnit = 1.5f;
        }
        else if (PlayerPrefs.GetInt("LevelTank") == 4)
        {
            _buffDamageByLevelTankUnit = 2f;
        }
    }
    
    private void BuffDamageByLevelAirport()
    {
        if (PlayerPrefs.GetInt("LevelAirport") == 1)
        {
            _buffDamageByLevelTankAirport = 1;
        }
        else if (PlayerPrefs.GetInt("LevelAirport") == 2)
        {
            _buffDamageByLevelTankAirport = 1.25f;
        }
        else if (PlayerPrefs.GetInt("LevelAirport") == 3)
        {
            _buffDamageByLevelTankAirport = 1.5f;
        }
        else if (PlayerPrefs.GetInt("LevelAirport") == 4)
        {
            _buffDamageByLevelTankAirport = 2f;
        }
    }
    
    private void BuffDamageByLevelRocketTurret()
    {
        if (PlayerPrefs.GetInt("LevelRocketTurret") == 1)
        {
            _buffDamageByLevelRocketTurret = 1;
        }
        else if (PlayerPrefs.GetInt("LevelRocketTurret") == 2)
        {
            _buffDamageByLevelRocketTurret = 1.25f;
        }
        else if (PlayerPrefs.GetInt("LevelRocketTurret") == 3)
        {
            _buffDamageByLevelRocketTurret = 1.5f;
        }
        else if (PlayerPrefs.GetInt("LevelRocketTurret") == 4)
        {
            _buffDamageByLevelRocketTurret = 2f;
        }
    }
    
    private void BuffDamageByLevelForceField()
    {
        if (PlayerPrefs.GetInt("LevelForceField") == 1)
        {
            _buffDamageByLevelForceField = 1;
        }
        else if (PlayerPrefs.GetInt("LevelForceField") == 2)
        {
            _buffDamageByLevelForceField = 1.2f;
        }
        else if (PlayerPrefs.GetInt("LevelForceField") == 3)
        {
            _buffDamageByLevelForceField = 1.5f;
        }
        else if (PlayerPrefs.GetInt("LevelForceField") == 4)
        {
            _buffDamageByLevelForceField = 2f;
        }
    }
}
