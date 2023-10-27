using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Vibration : MonoBehaviour
{
    [SerializeField]
    private Toggle _toggle;

    private void Start()
    {
        if(_toggle != null)
        {
            if(PlayerPrefs.GetInt("IsVibration") == 1)
            {
                _toggle.isOn = true;
            }
            if(PlayerPrefs.GetInt("IsVibration") == 0)
            {
                _toggle.isOn = false;
            }
        }
    }

    public static void GameOver()
    {
        if(PlayerPrefs.GetInt("IsVibration") == 1){
            Handheld.Vibrate();
        }
    }

    public void OnOffVibration()
    {
        if(_toggle.isOn == true)
        {
            PlayerPrefs.SetInt("IsVibration", 1);
            Debug.Log(PlayerPrefs.GetInt("IsVibration"));
        }
        if (_toggle.isOn == false)
        {
            PlayerPrefs.SetInt("IsVibration", 0);
            Debug.Log(PlayerPrefs.GetInt("IsVibration"));
        }
    }
}
