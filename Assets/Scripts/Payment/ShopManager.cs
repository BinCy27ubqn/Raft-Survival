using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopManager : MonoBehaviour
{
    [SerializeField]
    private Text _coinText;

    void Start()
    {
        _coinText.text = PlayerPrefs.GetInt("Money").ToString();
    }
}
