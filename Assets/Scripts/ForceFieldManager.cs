using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForceFieldManager : MonoBehaviour
{
    public static float levelUpDamageForceField=1f;

    void Start()
    {
        VariableStatic.isBuildForceField = true;

    }

    private void Update()
    {
        if(LightingHealth.forceFieldIsDie == true)
        {
            VariableStatic.isBuildForceField = false;
            levelUpDamageForceField = 1f;
            GameObject[] allLighting = GameObject.FindGameObjectsWithTag("LightingAttack");
            foreach(var lighting in allLighting)
            {
                lighting.SetActive(false);
            }
            LightingHealth.forceFieldIsDie = false;
        }
    }
}
