using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayCoinEarn : MonoBehaviour
{
    [SerializeField]
    private Text _textCoinEarn;

    void Start()
    {
        if (PlayerPrefs.GetInt("IncomeCurrentLevel") == 1)
        {
            _textCoinEarn.text = "+25 Coins";
        }
        else if (PlayerPrefs.GetInt("IncomeCurrentLevel") == 2)
        {
            _textCoinEarn.text = "+30 Coins";
        }
        else if (PlayerPrefs.GetInt("IncomeCurrentLevel") == 3)
        {
            _textCoinEarn.text = "+35 Coins";
        }
        else if (PlayerPrefs.GetInt("IncomeCurrentLevel") == 4)
        {
            _textCoinEarn.text = "+40 Coins";
        }
    }
}
