using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckLevelWhenStartGameFlameThrower : MonoBehaviour
{
    [SerializeField]
    private GameObject[] _flameThrower;

    void Start()
    {
        if (VariableStatic.isMainRaft == true )
        {
            if(PlayerPrefs.GetInt("IsStartGame") == 1)
            {
                if (PlayerPrefs.GetInt("LevelFlameThrower") == 1)
                {
                    _flameThrower[0].SetActive(true);
                    _flameThrower[1].SetActive(false);
                    _flameThrower[2].SetActive(false);
                    _flameThrower[3].SetActive(false);
                }
                if (PlayerPrefs.GetInt("LevelFlameThrower") == 2)
                {
                    Debug.Log(PlayerPrefs.GetInt("IsStartGame"));
                    _flameThrower[0].SetActive(false);
                    _flameThrower[1].SetActive(true);
                    _flameThrower[2].SetActive(false);
                    _flameThrower[3].SetActive(false);
                }
                if (PlayerPrefs.GetInt("LevelFlameThrower") == 3)
                {
                    _flameThrower[0].SetActive(false);
                    _flameThrower[1].SetActive(false);
                    _flameThrower[2].SetActive(true);
                    _flameThrower[3].SetActive(false);
                }
                if (PlayerPrefs.GetInt("LevelFlameThrower") == 4)
                {
                    _flameThrower[0].SetActive(false);
                    _flameThrower[1].SetActive(false);
                    _flameThrower[2].SetActive(false);
                    _flameThrower[3].SetActive(true);
                }
                VariableStatic.isMainRaft = false;
            }
        }
    }
}
