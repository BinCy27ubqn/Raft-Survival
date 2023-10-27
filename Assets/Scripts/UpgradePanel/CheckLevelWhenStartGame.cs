using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckLevelWhenStartGame : MonoBehaviour
{
    [SerializeField]
    private GameObject[] _soldierModule;

    void Start()
    {
        if (VariableStatic.isMainRaft == true && PlayerPrefs.GetInt("IsStartGame")==1) {
            if (PlayerPrefs.GetInt("LevelSoldier") == 1)
            {
                _soldierModule[0].SetActive(true);
                _soldierModule[1].SetActive(false);
                _soldierModule[2].SetActive(false);
                _soldierModule[3].SetActive(false);
            }
            if (PlayerPrefs.GetInt("LevelSoldier") == 2)
            {
                Debug.Log(PlayerPrefs.GetInt("IsStartGame"));
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
            VariableStatic.isMainRaft = false;
        }
    }
}
