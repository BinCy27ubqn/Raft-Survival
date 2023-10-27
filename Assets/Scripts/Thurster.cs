using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Thurster : MonoBehaviour
{
    private PlayerMovement _playerMovement;
    [SerializeField]
    private ThrusterLevelUp _thrusterLevelUp;
    public static float ecreaseSpeed = 0;
    private float ecreaseSpeedPercent = 1.1f;

    void Start()
    {
        _playerMovement = GameObject.Find("PlayerRaft").GetComponent<PlayerMovement>();

        float speedWereIncrease = _playerMovement._speed * ecreaseSpeedPercent;
        ecreaseSpeed = speedWereIncrease - _playerMovement._speed;
        _playerMovement._speed = speedWereIncrease;
    }

    private void Update()
    {
        if(ThrusterHealth.thrusterIsDie == true)
        {
            _playerMovement._speed = _playerMovement._speed - ecreaseSpeed - ThrusterLevelUp.ecreaseSpeed;
            ThrusterHealth.thrusterIsDie = false;
        }
    }
}
