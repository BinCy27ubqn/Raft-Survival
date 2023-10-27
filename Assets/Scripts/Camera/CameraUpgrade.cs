using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraUpgrade : MonoBehaviour
{
    [SerializeField]
    private GameObject _mainCamera;
    [SerializeField]
    private GameObject _upgradeCamera;

    private float increaseYCamera;

    void Update()
    {
        float minX = Mathf.Infinity;
        float maxX = -Mathf.Infinity;
        float minZ = Mathf.Infinity;
        float maxZ = -Mathf.Infinity;

        GameObject[] shipModules = GameObject.FindGameObjectsWithTag("ShipModule");
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
        }
        else if (distanceX <= 2.05 * 1)
        {
            increaseYCamera = 1.5f;
        }
        else if (distanceX <= 2.05 * 2)
        {
            increaseYCamera = 3.5f;
        }
        else if (distanceX <= 2.05 * 3)
        {
            increaseYCamera = 5.5f;
        }
        else if (distanceX <= 2.05 * 4)
        {
            increaseYCamera = 7.5f;
        }
        else if (distanceX <= 2.05 * 5)
        {
            increaseYCamera = 9.5f;
        }
        else if (distanceX <= 2.05 * 6)
        {
            increaseYCamera = 11.5f;
        }
        else if (distanceX <= 2.05 * 7)
        {
            increaseYCamera = 13.5f;
        }
        else if (distanceX <= 2.05 * 8)
        {
            increaseYCamera = 15.5f;
        }
        else if (distanceX <= 2.05 * 9)
        {
            increaseYCamera = 17.5f;
        }
        else if (distanceX <= 2.05 * 10)
        {
            increaseYCamera = 19.5f;
        }
        else if (distanceX <= 2.05 * 11)
        {
            increaseYCamera = 21.5f;
        }else if (distanceX <= 2.05 * 12)
        {
            increaseYCamera = 23.5f;
        }else if (distanceX <= 2.05 * 13)
        {
            increaseYCamera = 25.5f;
        }else if (distanceX <= 2.05 * 15)
        {
            increaseYCamera = 27.5f;
        }

        if (CameraRotate.IsUpgradeing == false)
        {
            _mainCamera.SetActive(true);
            _upgradeCamera.SetActive(false);
        }

        transform.position = CameraRotate.center + new Vector3(0, increaseYCamera,0);
    }
}
