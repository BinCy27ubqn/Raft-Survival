using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hack : MonoBehaviour
{
    private int _coin;
    [SerializeField]
    private Text _textCoin;

    private void Start()
    {
        _coin = PlayerPrefs.GetInt("Money");
    }
    public void Hacker()
    {
        _coin += 1000;
        PlayerPrefs.SetInt("Money", _coin);
        _textCoin.text = PlayerPrefs.GetInt("Money").ToString();
    }
}
