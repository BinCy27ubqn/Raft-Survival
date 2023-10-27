using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AroundMovement : MonoBehaviour
{
    [SerializeField]
    private float _radiusX = 2f;
    [SerializeField]
    private float _radiusZ = 2f;
    [SerializeField]
    private float _angularSpeed = 2f;

    private float _angle = 0;
    private float _posX = 0, _posz = 0;

    [SerializeField]
    private Transform _transformRotate;
    [SerializeField]
    private float _speedRotate;
    void Update()
    {
        GameObject[] shipModules = GameObject.FindGameObjectsWithTag("ShipModule");
        float minX = Mathf.Infinity;
        float maxX = -Mathf.Infinity;
        float minZ = Mathf.Infinity;
        float maxZ = -Mathf.Infinity;

        foreach(var ship in shipModules)
        {
            float xPosition = ship.transform.position.x;

            if(xPosition < minX)
            {
                minX = xPosition;
            }
            if(xPosition > maxX)
            {
                maxX = xPosition;
            }

            float zPosition = ship.transform.position.z;
            if (zPosition < minZ)
            {
                minZ = zPosition;
            }
            if (zPosition > maxZ)
            {
                maxZ = zPosition;
            }


        }

        float quantityX = maxX - minX;

        if(quantityX <= 2.05)
        {
            _radiusX = 4.5f;
        }else if(quantityX <= 2.05 * 2)
        {
            _radiusX = 5.5f;
        }
        else if(quantityX <= 2.05 * 3)
        {
            _radiusX = 6.5f;
        }
        else if(quantityX <= 2.05 * 4)
        {
            _radiusX = 7.5f;
        }
        else if(quantityX <= 2.05 * 5)
        {
            _radiusX = 8.5f;
        }else if(quantityX <= 2.05 * 6)
        {
            _radiusX = 9.5f;
        }else if(quantityX <= 2.05 * 7)
        {
            _radiusX = 10.5f;
        }else if(quantityX <= 2.05 * 8)
        {
            _radiusX = 11.5f;
        }else if(quantityX <= 2.05 * 9)
        {
            _radiusX = 12.5f;
        }else if(quantityX <= 2.05 * 10)
        {
            _radiusX = 12.5f;
        }
        
        float quantityZ = maxZ - minZ;

        if(quantityZ <= 2.05)
        {
            _radiusZ = 4.5f;
        }else if(quantityZ <= 2.05 * 2)
        {
            _radiusZ = 5.5f;
        }
        else if(quantityZ <= 2.05 * 3)
        {
            _radiusZ = 6.5f;
        }
        else if(quantityZ <= 2.05 * 4)
        {
            _radiusZ = 7.5f;
        }
        else if(quantityZ <= 2.05 * 5)
        {
            _radiusZ = 8.5f;
        }else if(quantityZ <= 2.05 * 6)
        {
            _radiusZ = 9.5f;
        }else if(quantityZ <= 2.05 * 7)
        {
            _radiusZ = 10.5f;
        }
        else if(quantityZ <= 2.05 * 8)
        {
            _radiusZ = 11.5f;
        }else if(quantityZ <= 2.05 * 9)
        {
            _radiusZ = 12.5f;
        }else if(quantityZ <= 2.05 * 10)
        {
            _radiusZ = 13.5f;
        }


        _posX = CameraRotate.center.x + Mathf.Cos(_angle) * _radiusX;
        _posz = CameraRotate.center.z + Mathf.Sin(_angle) * _radiusZ;

        transform.position = new Vector3(_posX, transform.position.y, _posz);
        _angle = _angle + Time.deltaTime * _angularSpeed;

        _transformRotate.Rotate(0, -_speedRotate * Time.deltaTime, 0);

        _angle = _angle % 360;


    }
}
