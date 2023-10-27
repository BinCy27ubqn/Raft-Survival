using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FlameLevelUp : MonoBehaviour
{
    [SerializeField]
    private List<GameObject> listLevel;
    [SerializeField]
    private GameObject _levelUpObject;

    public static int refIdUpgrade;

    [SerializeField]
    private Text _levelText;
    private int _currentLevel = 1;

    [SerializeField]
    private GameObject[] _CheckingLevel;

    [SerializeField]
    private LevelManager _levelManager;

    [SerializeField]
    private GameObject _upgradeFX;
    private void Start()
    {
        if (_CheckingLevel[0].activeSelf)
        {
            _currentLevel = 1;
            _levelText.text = "Level " + _currentLevel.ToString();
        }
        else if (_CheckingLevel[1].activeSelf)
        {
            _currentLevel = 2;
            _levelText.text = "Level " + _currentLevel.ToString();
        }
        else if (_CheckingLevel[2].activeSelf)
        {
            _currentLevel = 3;
            _levelText.text = "Level " + _currentLevel.ToString();
        }
        else if (_CheckingLevel[3].activeSelf)
        {
            _currentLevel = 4;
            _levelText.text = "Level " + _currentLevel.ToString();
        }
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
