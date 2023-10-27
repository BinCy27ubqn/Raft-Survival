using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedUp : MonoBehaviour
{
    public void SpeedUpTime()
    {
        Time.timeScale *= 2;
    }
    public void SpeedDownTime()
    {
        Time.timeScale /= 2;
    }
}
