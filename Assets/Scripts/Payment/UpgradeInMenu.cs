using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeInMenu : MonoBehaviour
{
    [SerializeField]
    private Text _priceText;
    [SerializeField]
    private Text _healthCurrentLevelText;
    [SerializeField]
    private Text _healthNextLevelText;
    
    [SerializeField]
    private Text _damageCurrentLevelText;
    [SerializeField]
    private Text _damageNextLevelText;
    
    [SerializeField]
    private Text _incomeCurrentLevelText;
    [SerializeField]
    private Text _incomeNextLevelText;

    private int _money;
    [SerializeField]
    private Text _moneyText;

    private void Start()
    {
        if (_healthCurrentLevelText != null && _healthNextLevelText != null)
        {
            _healthCurrentLevelText.text = PlayerPrefs.GetInt("HealthCurrentLevel").ToString();
            if (PlayerPrefs.GetInt("HealthCurrentLevel") < 4)
            {
                _priceText.text = PlayerPrefs.GetInt("HealthUpgradePrice").ToString();
                _healthNextLevelText.text = ">" + (PlayerPrefs.GetInt("HealthCurrentLevel") + 1).ToString();
            }
            else
            {
                _priceText.text = "Max";
                _healthNextLevelText.text = "";
            }
        }

        if (_damageCurrentLevelText != null && _damageNextLevelText != null)
        {
            _damageCurrentLevelText.text = PlayerPrefs.GetInt("DamageCurrentLevel").ToString();
            if (PlayerPrefs.GetInt("DamageCurrentLevel") < 4)
            {
                _priceText.text = PlayerPrefs.GetInt("DamageUpgradePrice").ToString();
                _damageNextLevelText.text = ">" + (PlayerPrefs.GetInt("DamageCurrentLevel") + 1).ToString();
            }
            else
            {
                _priceText.text = "Max";
                _damageNextLevelText.text = "";
            }
            
        }

        if (_incomeCurrentLevelText != null && _incomeNextLevelText != null)
        {
            _incomeCurrentLevelText.text = PlayerPrefs.GetInt("IncomeCurrentLevel").ToString();
            if (PlayerPrefs.GetInt("IncomeCurrentLevel") < 4)
            {
                _priceText.text = PlayerPrefs.GetInt("IncomeUpgradePrice").ToString();
                _incomeNextLevelText.text = ">" + (PlayerPrefs.GetInt("IncomeCurrentLevel") + 1).ToString();
            }
            else
            {
                _priceText.text = "Max";
                _incomeNextLevelText.text = "";
            }
        }
    }

    public void HealthUpgrade()
    {
        _money = PlayerPrefs.GetInt("Money");
        Debug.Log(_money);
        if (_money >= PlayerPrefs.GetInt("HealthUpgradePrice"))
        {
            if (PlayerPrefs.GetInt("HealthCurrentLevel") < 4)
            {
                _money -= PlayerPrefs.GetInt("HealthUpgradePrice");
                PlayerPrefs.SetInt("Money", _money);
                Debug.Log(PlayerPrefs.GetInt("Money"));
                _moneyText.text = _money.ToString();

                int increasePrice = PlayerPrefs.GetInt("HealthUpgradePrice") + 50;
                PlayerPrefs.SetInt("HealthUpgradePrice", increasePrice);
                _priceText.text = PlayerPrefs.GetInt("HealthUpgradePrice").ToString();

                int currentLevel = PlayerPrefs.GetInt("HealthCurrentLevel") + 1;
                PlayerPrefs.SetInt("HealthCurrentLevel", currentLevel);
                _healthCurrentLevelText.text = PlayerPrefs.GetInt("HealthCurrentLevel").ToString();
                int nextLevel = currentLevel + 1;
                _healthNextLevelText.text = ">" + nextLevel.ToString();
            }
            if (PlayerPrefs.GetInt("HealthCurrentLevel") == 4)
            {
                _priceText.text = "Max";
                _healthNextLevelText.text = "";
            }
        }
    }
    
    public void DamageUpgrade()
    {
        _money = PlayerPrefs.GetInt("Money");
        Debug.Log(_money);
        if (_money >= PlayerPrefs.GetInt("DamageUpgradePrice"))
        {
            if (PlayerPrefs.GetInt("DamageCurrentLevel") < 4)
            {
                _money -= PlayerPrefs.GetInt("DamageUpgradePrice");
                PlayerPrefs.SetInt("Money", _money);
                Debug.Log(PlayerPrefs.GetInt("Money"));
                _moneyText.text = _money.ToString();

                int increasePrice = PlayerPrefs.GetInt("DamageUpgradePrice") + 50;
                PlayerPrefs.SetInt("DamageUpgradePrice", increasePrice);
                _priceText.text = PlayerPrefs.GetInt("DamageUpgradePrice").ToString();

                int currentLevel = PlayerPrefs.GetInt("DamageCurrentLevel") + 1;
                PlayerPrefs.SetInt("DamageCurrentLevel", currentLevel);
                _damageCurrentLevelText.text = PlayerPrefs.GetInt("DamageCurrentLevel").ToString();
                int nextLevel = currentLevel + 1;
                _damageNextLevelText.text = ">" + nextLevel.ToString();
            }
            if (PlayerPrefs.GetInt("DamageCurrentLevel") == 4)
            {
                _priceText.text = "Max";
                _damageNextLevelText.text = "";
            }
        }
        
    }
    
    public void IncomeUpgrade()
    {
        _money = PlayerPrefs.GetInt("Money");
        Debug.Log(_money);
        if (_money >= PlayerPrefs.GetInt("IncomeUpgradePrice"))
        {
            if (PlayerPrefs.GetInt("IncomeCurrentLevel") < 4)
            {
                _money -= PlayerPrefs.GetInt("IncomeUpgradePrice");
                PlayerPrefs.SetInt("Money",_money);
                Debug.Log(PlayerPrefs.GetInt("Money"));
                _moneyText.text = _money.ToString();

                int increasePrice = PlayerPrefs.GetInt("IncomeUpgradePrice") + 50;
                PlayerPrefs.SetInt("IncomeUpgradePrice", increasePrice);
                _priceText.text = PlayerPrefs.GetInt("IncomeUpgradePrice").ToString();

                int currentLevel = PlayerPrefs.GetInt("IncomeCurrentLevel") + 1;
                PlayerPrefs.SetInt("IncomeCurrentLevel", currentLevel);
                _incomeCurrentLevelText.text = PlayerPrefs.GetInt("IncomeCurrentLevel").ToString();
                int nextLevel = currentLevel + 1;
                _incomeNextLevelText.text = ">" + nextLevel.ToString();
            }
            if (PlayerPrefs.GetInt("IncomeCurrentLevel") == 4)
            {
                _priceText.text = "Max";
                _incomeNextLevelText.text = "";
            }
        }
    }
}
