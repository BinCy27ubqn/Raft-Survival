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

        if (distanceX <= 0)
        {
            increaseYCamera = 0;
            increaseZCamera = 0;
        }
        else
        {
            float result = distanceX / 2.05f;

            increaseYCamera = 2f * result;
            increaseZCamera = 1f * result;
        }

        _targetPosition = new Vector3(center.x, center.y + 26f + increaseYCamera, center.z - 8.2f - increaseZCamera);

        transform.position = Vector3.Lerp(transform.position, _targetPosition, _timeSmooth);
        ///////RotateCamera
    }
}
