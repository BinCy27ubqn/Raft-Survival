using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeAndShopManager : MonoBehaviour
{
    [SerializeField]
    private int _coins;
    [SerializeField]
    private Text _textCoin;
    [SerializeField]
    private UpgradeItemSO[] _upgradeItemSOs;
    [SerializeField]
    private UpgradeTemplate[] _upgradeTemplates;

    private void Start()
    {
        LoadPanel();
    }

    public void AddCoin()
    {
        _coins++;
        _textCoin.text =_coins.ToString();
    }
    
    public void LoadPanel()
    {
        for(int i =0; i < _upgradeTemplates.Length; i++)
        {
            _upgradeTemplates[i]._title.text = _upgradeItemSOs[i]._title;
            _upgradeTemplates[i]._description.text = _upgradeItemSOs[i]._description;
            _upgradeTemplates[i]._coin.text = _upgradeItemSOs[i]._Cost.ToString();
            _upgradeTemplates[i]._coinUnlock.text = _upgradeItemSOs[i]._CostUnlock.ToString();
            _upgradeTemplates[i]._unit.sprite = _upgradeItemSOs[i]._unit;

        }
    }
}
