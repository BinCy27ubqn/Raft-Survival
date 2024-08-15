using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckLevelDamgeAirUnit : MonoBehaviour
{
    [SerializeField]
    private GameObject _levelUpObject;
    [SerializeField]
    private Text _levelText;
    private int _currentLevel = 1;

    public float ecreaseDamage = 1;

    [SerializeField]
    private GameObject _upgradeFX;

    private void Start()
    {
        _levelText.text = "Level " + _currentLevel.ToString();
    }

    private void OnMouseDown()
    {
        CameraRotate.IsUpgradeing = false;
        Time.timeScale = 1;
        Play.isProtected = false;
        LevelManager.isUpgrade = false;//disable upgrade grid
        _currentLevel++;
        _levelText.text = "Level " + _currentLevel.ToString();

        ecreaseDamage *= 1.2f;

        _levelUpObject.SetActive(false);//disbale upgrade unit
        
        _upgradeFX.SetActive(true);
        Invoke("enableUpgradeFX", 1f);

    }

    private void enableUpgradeFX()
    {
        _upgradeFX.SetActive(false);
    }
}
