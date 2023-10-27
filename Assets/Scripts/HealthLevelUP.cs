using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthLevelUP : MonoBehaviour
{
    [SerializeField]
    private GameObject _levelUpObject;

    [SerializeField]
    private Text _levelText;
    private int _currentLevel = 1;

    private float ecreaseHealthPercent = 1.1f;

    public static float ecreaseHealth = 0;

    [SerializeField]
    private GameObject _upgradeFX;
    private void Start()
    {
        _levelText.text = "Level " + _currentLevel.ToString();
    }

    private void OnMouseDown()
    {
        Time.timeScale = 1;
        CameraRotate.IsUpgradeing = false;
        Play.isProtected = false;
        LevelManager.isUpgrade = false;//disable upgrade grid
        _currentLevel++;
        _levelText.text = "Level " + _currentLevel.ToString();

        IncreaseDamage();
        HealthManager.isIncresaHealth = true;
        HealthUnit.healthIsBuild = true;

        _levelUpObject.SetActive(false);//disbale upgrade unit

        HealthManager.increaseHealth += 20;

        _upgradeFX.SetActive(true);
        Invoke("enableUpgradeFX", 1f);
    }
    
    public void IncreaseDamage()
    {
        float healthWereIncrease = HealthUnit.healthIncreaseByHealthUnit * ecreaseHealthPercent;
        ecreaseHealth = healthWereIncrease - HealthUnit.healthIncreaseByHealthUnit;
        DamageUnit.damageIncreaseByAttckUnit = healthWereIncrease;
    }

    private void enableUpgradeFX()
    {
        _upgradeFX.SetActive(false);
    }
}
