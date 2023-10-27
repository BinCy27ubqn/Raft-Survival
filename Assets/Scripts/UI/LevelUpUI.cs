using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelUpUI : MonoBehaviour
{
    [SerializeField]
    private GameObject _levelUI;

    // Update is called once per frame
    void Update()
    {
        if (LevelManager.levelUpUI == true)
        {
            _levelUI.SetActive(true);
            LevelManager.levelUpUI = false;
        }
    }
}
