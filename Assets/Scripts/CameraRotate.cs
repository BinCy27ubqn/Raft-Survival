using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotate : MonoBehaviour
{
    public static Vector3 center;
    private Vector3 _targetPosition;

    [SerializeField]
    private float _timeSmooth;

    float increaseYCamera;
    float increaseZCamera;

    private Animator _anim;

    private float _previousArrayLength;

    public static bool IsUpgradeing = false;
    [SerializeField]
    private GameObject _mainCamera;
    [SerializeField]
    private GameObject _upgradeCamera;

    private void Start()
    {
        _anim = GetComponent<Animator>();
        _anim.enabled = false;

        GameObject[] shipModules = GameObject.FindGameObjectsWithTag("ShipModule");
        _previousArrayLength = shipModules.Length;
    }
    [SerializeField]
    private float _timeSmoothPlayer;
    void Update()
    {
        RotateCamera();
        ZoomCameraWhenUpgrading();
    }

    private void ZoomCameraWhenUpgrading()
    {
        if (IsUpgradeing)
        {
            _mainCamera.SetActive(false);
            _upgradeCamera.SetActive(true);
        }
    }

    private void RotateCamera()
    {
        //RotateCamera
        GameObject[] shipModules = GameObject.FindGameObjectsWithTag("ShipModule");
        int currentArrayLength = shipModules.Length;

        if (currentArrayLength != _previousArrayLength)
        {
            _timeSmooth = 0.00001f;
        }
        else
        {
            _timeSmooth = Mathf.Lerp(_timeSmooth, 1f, _timeSmoothPlayer);
        }

        _previousArrayLength = currentArrayLength;

        center = Vector3.zero;
        foreach (GameObject ship in shipModules)
        {
            center += ship.transform.position;
        }

        center /= shipModules.Length;



        float minX = Mathf.Infinity;
        float maxX = -Mathf.Infinity;
        float minZ = Mathf.Infinity;
        float maxZ = -Mathf.Infinity;

        foreach (var ship in shipModules)
        {
            float posX = ship.transform.position.x;
            float posZ = ship.transform.position.z;

            if (posX < minX)
            {
                minX = posX;
            }
            if (posX > maxX)
            {
                maxX = posX;
            }

            if (posZ < minZ)
            {
                minZ = posZ;
            }
            if (posZ > maxZ)
            {
                maxZ = posZ;
            }
        }

        float distanceX = maxX - minX;
        float distanceZ = maxZ - minZ;



        if (distanceX <= 0)
        {
            increaseYCamera = 0;
            increaseZCamera = 0;
        }
        else if (distanceX <= 2.05 * 1)
        {
            increaseYCamera = 2f;
            increaseZCamera = 1f;
        }
        else if (distanceX <= 2.05 * 2)
        {
            increaseYCamera = 4f;
            increaseZCamera = 2f;
        }
        else if (distanceX <= 2.05 * 3)
        {
            increaseYCamera = 6f;
            increaseZCamera = 3f;
        }
        else if (distanceX <= 2.05 * 4)
        {
            increaseYCamera = 8f;
            increaseZCamera = 4f;
        }
        else if (distanceX <= 2.05 * 5)
        {
            increaseYCamera = 10f;
            increaseZCamera = 5f;
        }
        else if (distanceX <= 2.05 * 6)
        {
            increaseYCamera = 12f;
            increaseZCamera = 6f;
        }
        else if (distanceX <= 2.05 * 7)
        {
            increaseYCamera = 14f;
            increaseZCamera = 7f;
        }
        else if (distanceX <= 2.05 * 8)
        {
            increaseYCamera = 16f;
            increaseZCamera = 8f;
        }
        else if (distanceX <= 2.05 * 9)
        {
            increaseYCamera = 18f;
            increaseZCamera = 9f;
        }
        else if (distanceX <= 2.05 * 10)
        {
            increaseYCamera = 20;
            increaseZCamera = 10f;
        }
        else if (distanceX <= 2.05 * 11)
        {
            increaseYCamera = 22f;
            increaseZCamera = 11f;
        }

        _targetPosition = new Vector3(center.x, center.y + 26f + increaseYCamera, center.z - 8.2f - increaseZCamera);

        transform.position = Vector3.Lerp(transform.position, _targetPosition, _timeSmooth);
        ///////RotateCamera
    }
}
