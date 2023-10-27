using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopColor : MonoBehaviour
{
    [SerializeField]
    private GameObject[] _pricePanel;

    private int _coin;
    [SerializeField]
    private Text _coinText;

    [SerializeField]
    private Material _material;

    private void Start()
    {

        CheckRemovePanel("Color0", 0);
        CheckRemovePanel("Color1", 1);
        CheckRemovePanel("Color2", 2);
        CheckRemovePanel("Color3", 3);
        CheckRemovePanel("Color4", 4);
        CheckRemovePanel("Color5", 5);
        CheckRemovePanel("Color6", 6);
        CheckRemovePanel("Color7", 7);
    }

    private void Update()
    {
        _coin = PlayerPrefs.GetInt("Money");
    }
    public void RemovePanel(GameObject panel)
    {
        if(_coin > 100)
        {
            _coin -= 100;
            PlayerPrefs.SetInt("Money", _coin);
            _coinText.text = PlayerPrefs.GetInt("Money").ToString();
            panel.SetActive(false);
        }
    }
    
    public void RemovePanelStartGame(string colorNum)
    {
        PlayerPrefs.SetInt(colorNum, 1);
    }

    public void CheckRemovePanel(string colorNum, int num)
    {
        if(PlayerPrefs.GetInt(colorNum) == 1)
        {
            _pricePanel[num].SetActive(false);
        }
        else
        {
            _pricePanel[num].SetActive(true);
        }
    }

    public void ChangeColor()
    {
        _material.color = Color.green;
        PlayerPrefs.SetInt("ChooseColor", 1);
    }
    
    public void ChangeColorRed()
    {
        _material.color = Color.red;
        PlayerPrefs.SetInt("ChooseColor", 2);
    }
    
    public void ChangeColorPurple()
    {
        _material.color = new Color(128,0,128);
        PlayerPrefs.SetInt("ChooseColor", 3);
    }
    
    public void ChangeColorDarkBlue()
    {
        _material.color = Color.cyan;
        PlayerPrefs.SetInt("ChooseColor", 4);
    }
    
    public void ChangeColorOrange()
    {
        _material.color = new Color(1, 0.2039216f, 0);
        PlayerPrefs.SetInt("ChooseColor", 5);
    }
    
    public void ChangeColorSliver()
    {
        _material.color = new Color(192 , 192, 192);
        PlayerPrefs.SetInt("ChooseColor", 6);
    }
    
    public void ChangeColorBlue()
    {
        _material.color = Color.blue;
        PlayerPrefs.SetInt("ChooseColor", 7);
    }
    
    public void ChangeColorYellow()
    {
        _material.color = Color.yellow;
        PlayerPrefs.SetInt("ChooseColor", 8);
    }
}
