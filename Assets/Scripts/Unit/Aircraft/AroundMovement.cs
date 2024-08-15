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

        foreach (var ship in shipModules)
        {
            float xPosition = ship.transform.position.x;

            if (xPosition < minX)
            {
                minX = xPosition;
            }
            if (xPosition > maxX)
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
        if (quantityX <= 2.05 * 100)
        {
            _radiusX = 4.5f + (quantityX / 2.05f);
        }

        float quantityZ = maxZ - minZ;
        if (quantityZ <= 2.05 * 100)
        {
            _radiusZ = 4.5f + (quantityZ / 2.05f);
        }

        _posX = CameraRotate.center.x + Mathf.Cos(_angle) * _radiusX;
        _posz = CameraRotate.center.z + Mathf.Sin(_angle) * _radiusZ;

        transform.position = new Vector3(_posX, transform.position.y, _posz);
        _angle = _angle + Time.deltaTime * _angularSpeed;

        _transformRotate.Rotate(0, -_speedRotate * Time.deltaTime, 0);

        _angle = _angle % 360;
    }
}
