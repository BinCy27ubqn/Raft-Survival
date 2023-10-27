using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour
{
    private void Update()
    {
        if (VariableStatic.panelUpgradeIsShow == false)
        {
            gameObject.SetActive(false);
        }
    }
}
