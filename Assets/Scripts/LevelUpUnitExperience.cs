using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelUpUnitExperience : MonoBehaviour
{
    [SerializeField]
    private GameObject _levelUpObject;
    [SerializeField]
    private Text _levelText;
    private int _currentLevel = 1;

    [SerializeField]
    private LevelManager _levelManager;

    [SerializeField]
    private GameObject _upgradeFX;
    private void Start()
    {
        _levelManager = GameObject.Find("PlayerRaft").GetComponent<LevelManager>();
        _levelText.text = "Level " + _currentLevel.ToString();
    }

    private void OnMouseDown()
    {
        _levelManager._plusExperiencePoint = _levelManager._plusExperiencePoint * LevelManager.increaseExperience;
        CameraRotate.IsUpgradeing = false;
        Time.timeScale = 1;
        Play.isProtected = false;
        LevelManager.isUpgrade = false;//disable upgrade grid
        _currentLevel++;
        _levelText.text = "Level " + _currentLevel.ToString();

        _levelUpObject.SetActive(false);//disbale upgrade unit

        LevelManager.increaseExperience *= 1.4f;

        _upgradeFX.SetActive(true);
        Invoke("enableUpgradeFX", 1f);
    }

    private void enableUpgradeFX()
    {
        _upgradeFX.SetActive(false);
    }
}
