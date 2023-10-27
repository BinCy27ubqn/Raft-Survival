using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckUpgrade : MonoBehaviour
{
    [SerializeField]
    private int _idUpgrade;
    [SerializeField]
    private GameObject _levelUpObject;
    [SerializeField]
    private GameObject _upgradeGrid;

    [SerializeField]
    private GameObject _upgradeForceFied;

    void Start()
    {
        _upgradeGrid.SetActive(true);
        LevelUpUnit.refIdUpgrade = _idUpgrade;
    }

    private void Update()
    {
        if(VariableStatic.checkUpgrade[_idUpgrade] == true)
        {
            if (VariableStatic.displayUIUpgrade == true && _idUpgrade == UnitCardTemplate.numberCheckUnitCanUpgrade)
            {
                _levelUpObject.SetActive(true);
            }
        }
        else {
            _levelUpObject.SetActive(false);
        }

        if(VariableStatic.displayUIUpgrade == false)
        {
            _levelUpObject.SetActive(false);
        }

        if(VariableStatic.isBuildForceField == true)
        {
            _upgradeForceFied.SetActive(true);
        }
    }


}
