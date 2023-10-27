using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UITextBoss : MonoBehaviour
{
    [SerializeField]
    private Text _textDamage;

    private void Update()
    {
        _textDamage.text = ((int)BossHealth._damgeTaken).ToString();
    }
}
