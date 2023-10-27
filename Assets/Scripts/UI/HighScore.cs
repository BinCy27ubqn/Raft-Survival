using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScore : MonoBehaviour
{
    [SerializeField]
    private Text _highScoreText;
    void Start()
    {
        Application.targetFrameRate = 60;

        int hightScore = PlayerPrefs.GetInt("HighestTime");
        int mi = Mathf.FloorToInt(PlayerPrefs.GetInt("HighestTime") / 60);
        int se = Mathf.FloorToInt(PlayerPrefs.GetInt("HighestTime") % 60);
        string highestTime = string.Format("{0:00}:{1:00}", mi, se);
        _highScoreText.text = highestTime;

        if (PlayerPrefs.GetInt("HighestTime") <= Timer._curentTime)
        {
            PlayerPrefs.SetInt("HighestTime", (int)Timer._curentTime);
            int minutes = Mathf.FloorToInt(PlayerPrefs.GetInt("HighestTime") / 60);
            int seconds = Mathf.FloorToInt(PlayerPrefs.GetInt("HighestTime") % 60);
            string timeString = string.Format("{0:00}:{1:00}", minutes, seconds);
            _highScoreText.text = timeString;
        }
    }

    // Update is called once per frame
    void Update()
    {
        /*if (PlayerPrefs.GetInt("HighestTime") <= Timer._curentTime)
        {
            PlayerPrefs.SetInt("HighestTime", (int)Timer._curentTime);
            int minutes = Mathf.FloorToInt(PlayerPrefs.GetInt("HighestTime") / 60);
            int seconds = Mathf.FloorToInt(PlayerPrefs.GetInt("HighestTime") % 60);
            string timeString = string.Format("{0:00}:{1:00}", minutes, seconds);
            _highScoreText.text = timeString;
        }*/
    }
}
