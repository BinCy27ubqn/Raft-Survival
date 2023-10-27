using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PurchaseCharacter : MonoBehaviour
{
    [SerializeField]
    private List<GameObject> _units;
    [SerializeField]
    private List<GameObject> _locks;

    private int _coin;
    [SerializeField]
    private Text _textCoin;

    private int _panelUnlock = 1;
    [SerializeField]
    private List<Text> _priceUpgrade;

    [SerializeField]
    private GameObject[] _soldierModule;
    [SerializeField]
    private GameObject[] _flameModule;
    [SerializeField]
    private GameObject[] _forceFieldModule;


    private void Start()
    {
        _coin = PlayerPrefs.GetInt("Money");

        if (PlayerPrefs.GetInt("PanelLock1") == _panelUnlock)
        {
            _locks[0].SetActive(false);
        }
        else
        {
            _locks[0].SetActive(true);
        }
        if (PlayerPrefs.GetInt("PanelLock2") == _panelUnlock)
        {
            _locks[1].SetActive(false);
        }
        else
        {
            _locks[1].SetActive(true);
        }
        if (PlayerPrefs.GetInt("PanelLock3") == _panelUnlock)
        {
            _locks[2].SetActive(false);
        }
        else
        {
            _locks[2].SetActive(true);
        }

        if (PlayerPrefs.GetInt("PanelLock4") == _panelUnlock)
        {
            _locks[3].SetActive(false);
        }
        else
        {
            _locks[3].SetActive(true);
        }
        if (PlayerPrefs.GetInt("PanelLock5") == _panelUnlock)
        {
            _locks[4].SetActive(false);
        }
        else
        {
            _locks[4].SetActive(true);
        }
        if (PlayerPrefs.GetInt("PanelLock6") == _panelUnlock)
        {
            _locks[5].SetActive(false);
        }
        else
        {
            _locks[5].SetActive(true);
        }
    }

    private void Update()
    {
        _coin = PlayerPrefs.GetInt("Money");
        ShowPriceUpgrade("LevelSoldier",0);
        ShowPriceUpgrade("LevelFlameThrower",1);
        ShowPriceUpgrade("LevelForceField",2);
        ShowPriceUpgrade("LevelAirport",3);
        ShowPriceUpgrade("LevelTank",4);
        ShowPriceUpgrade("LevelRocketTurret",5);
        ShowPriceUpgrade("LevelTurret",6);
    }

    public void SoldierUnit()
    {
        _units[0].SetActive(true);
        foreach(var unit in _units)
        {
            if(_units[0] != unit) {
                unit.SetActive(false);
            }
        }
    }
    
    public void FlameUnit()
    {

        _units[1].SetActive(true);
        foreach(var unit in _units)
        {
            if(_units[1] != unit) {
                unit.SetActive(false);
            }
        }
    }
    
    public void ForceFieldUnit()
    {
        _units[2].SetActive(true);
        foreach(var unit in _units)
        {
            if(_units[2] != unit) {
                unit.SetActive(false);
            }
        }
    }
    public void AirportUnit()
    {
        _units[3].SetActive(true);
        foreach(var unit in _units)
        {
            if(_units[3] != unit) {
                unit.SetActive(false);
            }
        }
    }
    public void TankUnit()
    {
        _units[4].SetActive(true);
        foreach(var unit in _units)
        {
            if(_units[4] != unit) {
                unit.SetActive(false);
            }
        }
    }
    public void RocketTurretUnit()
    {
        _units[5].SetActive(true);
        foreach(var unit in _units)
        {
            if(_units[5] != unit) {
                unit.SetActive(false);
            }
        }
    }
    public void TurretUnit()
    {
        _units[6].SetActive(true);
        foreach(var unit in _units)
        {
            if(_units[6] != unit) {
                unit.SetActive(false);
            }
        }
    }

    //unlock unit
    public void LockFlame()
    {
        if (_coin >= 200)
        {
            _coin = _coin - 200;
            PlayerPrefs.SetInt("Money", _coin);
            _textCoin.text = PlayerPrefs.GetInt("Money").ToString();
            _locks[0].SetActive(false);

            PlayerPrefs.SetInt("PanelLock1", _panelUnlock);
        }
    }
    
    public void LockForceField()
    {
        if (_coin >= 200)
        {
            _coin = _coin - 200;
            PlayerPrefs.SetInt("Money", _coin);
            _textCoin.text = PlayerPrefs.GetInt("Money").ToString();
            _locks[1].SetActive(false);

            PlayerPrefs.SetInt("PanelLock2", _panelUnlock);
        }
    }
    
    public void LockAirport()
    {
        if (_coin >= 200)
        {
            _coin = _coin - 200;
            PlayerPrefs.SetInt("Money", _coin);
            _textCoin.text = PlayerPrefs.GetInt("Money").ToString();
            _locks[2].SetActive(false);

            PlayerPrefs.SetInt("PanelLock3", _panelUnlock);
        }
    }
    
    public void LockTank()
    {
        if (_coin >= 200)
        {
            _coin = _coin - 200;
            PlayerPrefs.SetInt("Money", _coin);
            _textCoin.text = PlayerPrefs.GetInt("Money").ToString();
            _locks[3].SetActive(false);

            PlayerPrefs.SetInt("PanelLock4", _panelUnlock);
        }
    }
    public void LockRocketTurret()
    {
        if (_coin >= 200)
        {
            _coin = _coin - 200;
            PlayerPrefs.SetInt("Money", _coin);
            _textCoin.text = PlayerPrefs.GetInt("Money").ToString();
            _locks[4].SetActive(false);

            PlayerPrefs.SetInt("PanelLock5", _panelUnlock);
        }
    }
    public void LockTurret()
    {
        if (_coin >= 200)
        {
            _coin = _coin - 200;
            PlayerPrefs.SetInt("Money", _coin);
            _textCoin.text = PlayerPrefs.GetInt("Money").ToString();
            _locks[5].SetActive(false);

            PlayerPrefs.SetInt("PanelLock6", _panelUnlock);
        }
    }

    //Purchase upgrade unit
    public void UpgradeSolider()
    {
        if(PlayerPrefs.GetInt("LevelSoldier") == 1)
        {
            if(_coin >= 100)
            {
                _coin -= 100;
                PlayerPrefs.SetInt("Money", _coin);
                _textCoin.text = PlayerPrefs.GetInt("Money").ToString();
                PlayerPrefs.SetInt("LevelSoldier", 2);

                _soldierModule[0].SetActive(false);
                _soldierModule[1].SetActive(true);
            }
        }else if(PlayerPrefs.GetInt("LevelSoldier") == 2)
        {
            if(_coin >= 150)
            {
                _coin -= 150;
                PlayerPrefs.SetInt("Money", _coin);
                _textCoin.text = PlayerPrefs.GetInt("Money").ToString();
                PlayerPrefs.SetInt("LevelSoldier", 3);

                _soldierModule[1].SetActive(false);
                _soldierModule[2].SetActive(true);
            }
        }else if(PlayerPrefs.GetInt("LevelSoldier") == 3)
        {
            if(_coin >= 200)
            {
                _coin -= 200;
                PlayerPrefs.SetInt("Money", _coin);
                _textCoin.text = PlayerPrefs.GetInt("Money").ToString();
                PlayerPrefs.SetInt("LevelSoldier", 4);

                _soldierModule[2].SetActive(false);
                _soldierModule[3].SetActive(true);
            }
        }
    }

    public void UpgradeFlameThrower()
    {
        if(PlayerPrefs.GetInt("LevelFlameThrower") == 1)
        {
            if(_coin >= 100)
            {
                _coin -= 100;
                PlayerPrefs.SetInt("Money", _coin);
                _textCoin.text = PlayerPrefs.GetInt("Money").ToString();
                PlayerPrefs.SetInt("LevelFlameThrower", 2);

                _flameModule[0].SetActive(false);
                _flameModule[1].SetActive(true);
            }
        }else if(PlayerPrefs.GetInt("LevelFlameThrower") == 2)
        {
            if(_coin >= 150)
            {
                _coin -= 150;
                PlayerPrefs.SetInt("Money", _coin);
                _textCoin.text = PlayerPrefs.GetInt("Money").ToString();
                PlayerPrefs.SetInt("LevelFlameThrower", 3);

                _flameModule[1].SetActive(false);
                _flameModule[2].SetActive(true);
            }
        }else if(PlayerPrefs.GetInt("LevelFlameThrower") == 3)
        {
            if(_coin >= 200)
            {
                _coin -= 200;
                PlayerPrefs.SetInt("Money", _coin);
                _textCoin.text = PlayerPrefs.GetInt("Money").ToString();
                PlayerPrefs.SetInt("LevelFlameThrower", 4);

                _flameModule[2].SetActive(false);
                _flameModule[3].SetActive(true);
            }
        }
    }
    
    public void UpgradeForceField()
    {
        if(PlayerPrefs.GetInt("LevelForceField") == 1)
        {
            if(_coin >= 100)
            {
                _coin -= 100;
                PlayerPrefs.SetInt("Money", _coin);
                _textCoin.text = PlayerPrefs.GetInt("Money").ToString();
                PlayerPrefs.SetInt("LevelForceField", 2);

                _forceFieldModule[0].SetActive(false);
                _forceFieldModule[1].SetActive(true);
            }
        }else if(PlayerPrefs.GetInt("LevelForceField") == 2)
        {
            if(_coin >= 150)
            {
                _coin -= 150;
                PlayerPrefs.SetInt("Money", _coin);
                _textCoin.text = PlayerPrefs.GetInt("Money").ToString();
                PlayerPrefs.SetInt("LevelForceField", 3);

                _forceFieldModule[1].SetActive(false);
                _forceFieldModule[2].SetActive(true);
            }
        }else if(PlayerPrefs.GetInt("LevelForceField") == 3)
        {
            if(_coin >= 200)
            {
                _coin -= 200;
                PlayerPrefs.SetInt("Money", _coin);
                _textCoin.text = PlayerPrefs.GetInt("Money").ToString();
                PlayerPrefs.SetInt("LevelForceField", 4);

                _forceFieldModule[2].SetActive(false);
                _forceFieldModule[3].SetActive(true);
            }
        }
    }
    public void UpgradeAirport()
    {
        if(PlayerPrefs.GetInt("LevelAirport") == 1)
        {
            if(_coin >= 100)
            {
                _coin -= 100;
                PlayerPrefs.SetInt("Money", _coin);
                _textCoin.text = PlayerPrefs.GetInt("Money").ToString();
                PlayerPrefs.SetInt("LevelAirport", 2);
            }
        }else if(PlayerPrefs.GetInt("LevelAirport") == 2)
        {
            if(_coin >= 150)
            {
                _coin -= 150;
                PlayerPrefs.SetInt("Money", _coin);
                _textCoin.text = PlayerPrefs.GetInt("Money").ToString();
                PlayerPrefs.SetInt("LevelAirport", 3);
            }
        }else if(PlayerPrefs.GetInt("LevelAirport") == 3)
        {
            if(_coin >= 200)
            {
                _coin -= 200;
                PlayerPrefs.SetInt("Money", _coin);
                _textCoin.text = PlayerPrefs.GetInt("Money").ToString();
                PlayerPrefs.SetInt("LevelAirport", 4);
            }
        }
    }
    public void UpgradeTank()
    {
        if(PlayerPrefs.GetInt("LevelTank") == 1)
        {
            if(_coin >= 100)
            {
                _coin -= 100;
                PlayerPrefs.SetInt("Money", _coin);
                _textCoin.text = PlayerPrefs.GetInt("Money").ToString();
                PlayerPrefs.SetInt("LevelTank", 2);
            }
        }else if(PlayerPrefs.GetInt("LevelTank") == 2)
        {
            if(_coin >= 150)
            {
                _coin -= 150;
                PlayerPrefs.SetInt("Money", _coin);
                _textCoin.text = PlayerPrefs.GetInt("Money").ToString();
                PlayerPrefs.SetInt("LevelTank", 3);
            }
        }else if(PlayerPrefs.GetInt("LevelTank") == 3)
        {
            if(_coin >= 200)
            {
                _coin -= 200;
                PlayerPrefs.SetInt("Money", _coin);
                _textCoin.text = PlayerPrefs.GetInt("Money").ToString();
                PlayerPrefs.SetInt("LevelTank", 4);
            }
        }
    }public void UpgradeRocketTurret()
    {
        if(PlayerPrefs.GetInt("LevelRocketTurret") == 1)
        {
            if(_coin >= 100)
            {
                _coin -= 100;
                PlayerPrefs.SetInt("Money", _coin);
                _textCoin.text = PlayerPrefs.GetInt("Money").ToString();
                PlayerPrefs.SetInt("LevelRocketTurret", 2);
            }
        }else if(PlayerPrefs.GetInt("LevelRocketTurret") == 2)
        {
            if(_coin >= 150)
            {
                _coin -= 150;
                PlayerPrefs.SetInt("Money", _coin);
                _textCoin.text = PlayerPrefs.GetInt("Money").ToString();
                PlayerPrefs.SetInt("LevelRocketTurret", 3);
            }
        }else if(PlayerPrefs.GetInt("LevelRocketTurret") == 3)
        {
            if(_coin >= 200)
            {
                _coin -= 200;
                PlayerPrefs.SetInt("Money", _coin);
                _textCoin.text = PlayerPrefs.GetInt("Money").ToString();
                PlayerPrefs.SetInt("LevelRocketTurret", 4);
            }
        }
    }public void UpgradeTurret()
    {
        if(PlayerPrefs.GetInt("LevelTurret") == 1)
        {
            if(_coin >= 100)
            {
                _coin -= 100;
                PlayerPrefs.SetInt("Money", _coin);
                _textCoin.text = PlayerPrefs.GetInt("Money").ToString();
                PlayerPrefs.SetInt("LevelTurret", 2);
            }
        }else if(PlayerPrefs.GetInt("LevelTurret") == 2)
        {
            if(_coin >= 150)
            {
                _coin -= 150;
                PlayerPrefs.SetInt("Money", _coin);
                _textCoin.text = PlayerPrefs.GetInt("Money").ToString();
                PlayerPrefs.SetInt("LevelTurret", 3);
            }
        }else if(PlayerPrefs.GetInt("LevelTurret") == 3)
        {
            if(_coin >= 200)
            {
                _coin -= 200;
                PlayerPrefs.SetInt("Money", _coin);
                _textCoin.text = PlayerPrefs.GetInt("Money").ToString();
                PlayerPrefs.SetInt("LevelTurret", 4);
            }
        }
    }

    public void ShowPriceUpgrade(string levelUnit, int idUnit)
    {
        if (PlayerPrefs.GetInt(levelUnit) == 1)
        {
            _priceUpgrade[idUnit].text = "100";
        }
        else if (PlayerPrefs.GetInt(levelUnit) == 2)
        {
            _priceUpgrade[idUnit].text = "150";
        }
        else if (PlayerPrefs.GetInt(levelUnit) == 3)
        {
            _priceUpgrade[idUnit].text = "200";
        }
        else if (PlayerPrefs.GetInt(levelUnit) == 4) 
        {
            _priceUpgrade[idUnit].text = "Max";
            _priceUpgrade[idUnit].fontSize = 42;
        }
    }
}
