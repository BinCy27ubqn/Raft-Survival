using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    [SerializeField]
    private SpriteRenderer _spriteRenderer;
    [SerializeField]
    private SpriteRenderer[] _spriteRendererFlag;
    [SerializeField]
    private SpriteRenderer[] _spriteRendererFlagStaff;

    void Update()
    {
        if (PlayerPrefs.GetInt("ChooseColor") == 1)
        {
            _spriteRenderer.color = Color.green;
            _spriteRendererFlag[0].color = Color.green;
            _spriteRendererFlag[1].color = Color.green;
            _spriteRendererFlag[2].color = Color.green;
            _spriteRendererFlag[3].color = Color.green;
            _spriteRendererFlagStaff[0].color = Color.green;
            _spriteRendererFlagStaff[1].color = Color.green;
            _spriteRendererFlagStaff[2].color = Color.green;
            _spriteRendererFlagStaff[3].color = Color.green;

        }
        else if (PlayerPrefs.GetInt("ChooseColor") == 2)
        {
            _spriteRenderer.color = Color.red;
            _spriteRendererFlag[0].color = Color.red;
            _spriteRendererFlag[1].color = Color.red;
            _spriteRendererFlag[2].color = Color.red;
            _spriteRendererFlag[3].color = Color.red;
            _spriteRendererFlagStaff[0].color = Color.red;
            _spriteRendererFlagStaff[1].color = Color.red;
            _spriteRendererFlagStaff[2].color = Color.red;
            _spriteRendererFlagStaff[3].color = Color.red;
        }
        else if (PlayerPrefs.GetInt("ChooseColor") == 3)
        {
            _spriteRenderer.color = new Color(128,0,128);
            _spriteRendererFlag[0].color = new Color(128, 0, 128);
            _spriteRendererFlag[1].color = new Color(128, 0, 128);
            _spriteRendererFlag[2].color = new Color(128, 0, 128);
            _spriteRendererFlag[3].color = new Color(128, 0, 128);
            _spriteRendererFlagStaff[0].color = new Color(128, 0, 128);
            _spriteRendererFlagStaff[1].color = new Color(128, 0, 128);
            _spriteRendererFlagStaff[2].color = new Color(128, 0, 128);
            _spriteRendererFlagStaff[3].color = new Color(128, 0, 128);
        }
        else if (PlayerPrefs.GetInt("ChooseColor") == 4)
        {
            _spriteRenderer.color = Color.cyan;
            _spriteRendererFlag[0].color = Color.cyan;
            _spriteRendererFlag[1].color = Color.cyan;
            _spriteRendererFlag[2].color = Color.cyan;
            _spriteRendererFlag[3].color = Color.cyan;
            _spriteRendererFlagStaff[0].color = Color.cyan;
            _spriteRendererFlagStaff[1].color = Color.cyan;
            _spriteRendererFlagStaff[2].color = Color.cyan;
            _spriteRendererFlagStaff[3].color = Color.cyan;
        }
        else if (PlayerPrefs.GetInt("ChooseColor") == 5)
        {
            _spriteRenderer.color = new Color(1, 0.2039216f, 0);
            _spriteRendererFlag[0].color = new Color(1, 0.2039216f, 0);
            _spriteRendererFlag[1].color = new Color(1, 0.2039216f, 0);
            _spriteRendererFlag[2].color = new Color(1, 0.2039216f, 0);
            _spriteRendererFlag[3].color = new Color(1, 0.2039216f, 0);
            _spriteRendererFlagStaff[0].color = new Color(1, 0.2039216f, 0);
            _spriteRendererFlagStaff[1].color = new Color(1, 0.2039216f, 0);
            _spriteRendererFlagStaff[2].color = new Color(1, 0.2039216f, 0);
            _spriteRendererFlagStaff[3].color = new Color(1, 0.2039216f, 0);
        }
        else if (PlayerPrefs.GetInt("ChooseColor") == 6)
        {
            _spriteRenderer.color = new Color(192, 192, 192);
            _spriteRendererFlag[0].color = new Color(192, 192, 192);
            _spriteRendererFlag[1].color = new Color(192, 192, 192);
            _spriteRendererFlag[2].color = new Color(192, 192, 192);
            _spriteRendererFlag[3].color = new Color(192, 192, 192);
            _spriteRendererFlagStaff[0].color = new Color(192, 192, 192);
            _spriteRendererFlagStaff[1].color = new Color(192, 192, 192);
            _spriteRendererFlagStaff[2].color = new Color(192, 192, 192);
            _spriteRendererFlagStaff[3].color = new Color(192, 192, 192);
        }
        else if (PlayerPrefs.GetInt("ChooseColor") == 7)
        {
            _spriteRenderer.color = Color.blue;
            _spriteRendererFlag[0].color = Color.blue;
            _spriteRendererFlag[1].color = Color.blue;
            _spriteRendererFlag[2].color = Color.blue;
            _spriteRendererFlag[3].color = Color.blue;
            _spriteRendererFlagStaff[0].color = Color.blue;
            _spriteRendererFlagStaff[1].color = Color.blue;
            _spriteRendererFlagStaff[2].color = Color.blue;
            _spriteRendererFlagStaff[3].color = Color.blue;
        }
        else if (PlayerPrefs.GetInt("ChooseColor") == 8)
        {
            _spriteRenderer.color = Color.yellow;
            _spriteRendererFlag[0].color = Color.yellow;
            _spriteRendererFlag[1].color = Color.yellow;
            _spriteRendererFlag[2].color = Color.yellow;
            _spriteRendererFlag[3].color = Color.yellow;
            _spriteRendererFlagStaff[0].color = Color.yellow;
            _spriteRendererFlagStaff[1].color = Color.yellow;
            _spriteRendererFlagStaff[2].color = Color.yellow;
            _spriteRendererFlagStaff[3].color = Color.yellow;
        }
    }
}
