using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckLevelWhenStartGameForceField : MonoBehaviour
{
    [SerializeField]
    private GameObject[] _forceField;

    void Start()
    {
        if (VariableStatic.isMainRaft == true)
        {
            if (PlayerPrefs.GetInt("IsStartGame") == 1)
            {
                if (PlayerPrefs.GetInt("LevelForceField") == 1)
                {
                    _forceField[0].SetActive(true);
                    _forceField[1].SetActive(false);
                    _forceField[2].SetActive(false);
                    _forceField[3].SetActive(false);
                }
                if (PlayerPrefs.GetInt("LevelForceField") == 2)
                {
                    Debug.Log(PlayerPrefs.GetInt("IsStartGame"));
                    _forceField[0].SetActive(false);
                    _forceField[1].SetActive(true);
                    _forceField[2].SetActive(false);
                    _forceField[3].SetActive(false);
                }
                if (PlayerPrefs.GetInt("LevelForceField") == 3)
                {
                    _forceField[0].SetActive(false);
                    _forceField[1].SetActive(false);
                    _forceField[2].SetActive(true);
                    _forceField[3].SetActive(false);
                }
                if (PlayerPrefs.GetInt("LevelForceField") == 4)
                {
                    _forceField[0].SetActive(false);
                    _forceField[1].SetActive(false);
                    _forceField[2].SetActive(false);
                    _forceField[3].SetActive(true);
                }
                VariableStatic.isMainRaft = false;
            }
        }
    }
}
