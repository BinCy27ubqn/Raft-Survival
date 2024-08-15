using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseVibration : MonoBehaviour
{
    private void Start()
    {
        Debug.Log(gameObject.name + "sss");
    }
    public void LoseVa()
    {
        Handheld.Vibrate();
    }
}
