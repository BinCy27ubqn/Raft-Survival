using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectUnit : MonoBehaviour
{
    [SerializeField]
    private List<GameObject> _unit;

    [SerializeField]
    private GameObject[] _soldierModule;
    [SerializeField]
    private GameObject[] _flameModule;
    [SerializeField]
    private GameObject[] _forceFieldModule;
    private void Awake()
    {
        Time.timeScale = 1;
        PlayerPrefs.SetInt("IsStartGame", 0);
    }

    private void Start()
    {
        VariableStatic.numberCard.Clear();
        Play.quantityEnenyDie = 0;
        Play.quantityCoinEarned = 0;

        for (int i = 0; i < 7; i++)
        {
            if (PlayerPrefs.GetInt("CharacterSelection") - 1 == i)
            {
                _unit[i].SetActive(true);
            }
            else
            {
                _unit[i].SetActive(false);
            }
        }

        CheckLevelDisplaySoldier();
        CheckLevelDisplayFlame();
        CheckLevelDisplayForceField();

    }

    public void ChooseUnit(int idUnit)
    {
        PlayerPrefs.SetInt("CharacterSelection", idUnit);
    }

    public void CheckLevelDisplaySoldier()
    {
        if (PlayerPrefs.GetInt("LevelSoldier") == 1)
        {
            _soldierModule[0].SetActive(true);
            _soldierModule[1].SetActive(false);
            _soldierModule[2].SetActive(false);
            _soldierModule[3].SetActive(false);
        }
        if (PlayerPrefs.GetInt("LevelSoldier") == 2)
        {
            _soldierModule[0].SetActive(false);
            _soldierModule[1].SetActive(true);
            _soldierModule[2].SetActive(false);
            _soldierModule[3].SetActive(false);
        }
        if (PlayerPrefs.GetInt("LevelSoldier") == 3)
        {
            _soldierModule[0].SetActive(false);
            _soldierModule[1].SetActive(false);
            _soldierModule[2].SetActive(true);
            _soldierModule[3].SetActive(false);
        }
        if (PlayerPrefs.GetInt("LevelSoldier") == 4)
        {
            _soldierModule[0].SetActive(false);
            _soldierModule[1].SetActive(false);
            _soldierModule[2].SetActive(false);
            _soldierModule[3].SetActive(true);
        }
    }
    
    public void CheckLevelDisplayFlame()
    {
        if (PlayerPrefs.GetInt("LevelFlameThrower") == 1)
        {
            _flameModule[0].SetActive(true);
            _flameModule[1].SetActive(false);
            _flameModule[2].SetActive(false);
            _flameModule[3].SetActive(false);
        }
        if (PlayerPrefs.GetInt("LevelFlameThrower") == 2)
        {
            _flameModule[0].SetActive(false);
            _flameModule[1].SetActive(true);
            _flameModule[2].SetActive(false);
            _flameModule[3].SetActive(false);
        }
        if (PlayerPrefs.GetInt("LevelFlameThrower") == 3)
        {
            _flameModule[0].SetActive(false);
            _flameModule[1].SetActive(false);
            _flameModule[2].SetActive(true);
            _flameModule[3].SetActive(false);
        }
        if (PlayerPrefs.GetInt("LevelFlameThrower") == 4)
        {
            _flameModule[0].SetActive(false);
            _flameModule[1].SetActive(false);
            _flameModule[2].SetActive(false);
            _flameModule[3].SetActive(true);
        }
    }
    
    public void CheckLevelDisplayForceField()
    {
        if (PlayerPrefs.GetInt("LevelForceField") == 1)
        {
            _forceFieldModule[0].SetActive(true);
            _forceFieldModule[1].SetActive(false);
            _forceFieldModule[2].SetActive(false);
            _forceFieldModule[3].SetActive(false);
        }
        if (PlayerPrefs.GetInt("LevelForceField") == 2)
        {
            _forceFieldModule[0].SetActive(false);
            _forceFieldModule[1].SetActive(true);
            _forceFieldModule[2].SetActive(false);
            _forceFieldModule[3].SetActive(false);
        }
        if (PlayerPrefs.GetInt("LevelForceField") == 3)
        {
            _forceFieldModule[0].SetActive(false);
            _forceFieldModule[1].SetActive(false);
            _forceFieldModule[2].SetActive(true);
            _forceFieldModule[3].SetActive(false);
        }
        if (PlayerPrefs.GetInt("LevelForceField") == 4)
        {
            _forceFieldModule[0].SetActive(false);
            _forceFieldModule[1].SetActive(false);
            _forceFieldModule[2].SetActive(false);
            _forceFieldModule[3].SetActive(true);
        }
    }
}
