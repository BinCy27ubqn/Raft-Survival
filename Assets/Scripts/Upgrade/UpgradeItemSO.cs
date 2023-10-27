using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


[CreateAssetMenu(fileName = "UpgradeShop",menuName = "Scriptable Object/Shop Upgrade",order = 1)]
public class UpgradeItemSO : ScriptableObject
{
    public string _title;
    public string _description;
    public int _Cost;
    public int _CostUnlock;
    public Sprite _unit;

}
