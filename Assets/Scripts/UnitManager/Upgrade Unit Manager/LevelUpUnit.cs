using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelUpUnit : MonoBehaviour
{
    [SerializeField]
    private List<GameObject> listLevel;
    [SerializeField]
    private GameObject _levelUpObject;

    public static int refIdUpgrade;

    [SerializeField]
    private Text _levelText;
    private int _currentLevel=1;

    [SerializeField]
    private GameObject _upgradeFX;
    private void Start()
    {
        _levelText.text = "Level " + _currentLevel.ToString();
    }

    private void OnMouseDown()
    {

        Play.isProtected = false;
        if (_currentLevel < 4)
        {
            listLevel[_currentLevel].SetActive(true);
            listLevel[_currentLevel - 1].SetActive(false);

            VariableStatic._currentLevel++;
            VariableStatic.checkUpgrade[refIdUpgrade] = false;
            CameraRotate.IsUpgradeing = false;

            _currentLevel++;
            _levelText.text = "Level " + _currentLevel.ToString();
            Time.timeScale = 1f;
            //End of upgrade
            LevelManager.isUpgrade = false;
            _levelUpObject.SetActive(false);

            _upgradeFX.SetActive(true);
            Invoke("enableUpgradeFX", 1f);
        }
    }

    private void enableUpgradeFX()
    {
        _upgradeFX.SetActive(false);
    }
}
