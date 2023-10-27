using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneyManager : MonoBehaviour
{
    public static int _money;
    [SerializeField]
    private Text _text;
    private void Start()
    {
        _money = PlayerPrefs.GetInt("Money");
        _text.text = _money.ToString();
    }
}
