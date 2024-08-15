using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthManager : MonoBehaviour
{
    public static float health = 20;
    public static float increaseHealth;

    public static bool isIncresaHealth;

    private void Awake()
    {
        if (PlayerPrefs.GetInt("HealthCurrentLevel") == 1)
        {
            health = 20;
            increaseHealth = 20;
        }
        else if (PlayerPrefs.GetInt("HealthCurrentLevel") == 2)
        {
            health = 25;
            increaseHealth = 25;
        }
        else if (PlayerPrefs.GetInt("HealthCurrentLevel") == 3)
        {
            health = 30;
            increaseHealth = 30;
        }
        else if (PlayerPrefs.GetInt("HealthCurrentLevel") == 4)
        {
            health = 40;
            increaseHealth = 40;
        }
    }
}
