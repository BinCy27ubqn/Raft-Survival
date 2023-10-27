using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseGame : MonoBehaviour
{
    [SerializeField]
    private GameObject _panelLoseGame;
    private void Update()
    {
        if (PlayerHealth.IsDie == true)
        {
            _panelLoseGame.SetActive(true);
        }
    }

    private void Awake()
    {
        PlayerHealth.IsDie = false;

    }
}
