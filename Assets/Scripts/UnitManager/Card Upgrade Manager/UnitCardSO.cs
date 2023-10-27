using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "UpgradeCard",menuName ="Scriptable Objects/Card Upgrade",order = 1)]
public class UnitCardSO : ScriptableObject
{
    public string title;
    public string description;
    public Sprite sprite;
    public string isUpgrade;
}
