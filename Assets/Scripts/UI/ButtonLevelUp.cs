using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonLevelUp : MonoBehaviour
{
    [SerializeField]
    private LevelManager _levelManager;
    [SerializeField]
    private float _pointIncrease;
    public void LevelUpB()
    {
        _levelManager._pointExperience += _pointIncrease;
    }
}
