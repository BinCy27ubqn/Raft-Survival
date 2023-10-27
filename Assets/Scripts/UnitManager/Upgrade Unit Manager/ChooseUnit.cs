using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChooseUnit : MonoBehaviour
{
    [SerializeField]
    private PickMoreUnit _pickMoreUnit;

    private GameObject _cameraZoom;
    private void Start()
    {
        Time.timeScale = 1;
    }



    private void FixedUpdate()
    {
        if (VariableStatic.CanChoose == false)
        {
            Time.timeScale = 0;
        }
    }

    private void OnMouseDown()
    {
        _cameraZoom = GameObject.Find("CameraUpgrade");
        _cameraZoom.transform.position = transform.position;
        CameraRotate.IsUpgradeing = false;
        Play.isProtected = false;
        if(VariableStatic._unitPrefab != null)
        {
            Instantiate(VariableStatic._unitPrefab, gameObject.transform.position -  new Vector3(0,0.26f,0), transform.rotation, gameObject.transform.parent);
            Time.timeScale = 1f;
            _cameraZoom.transform.position = gameObject.transform.position;
        }
        LevelManager.isUpgrade = false;
        //Destroy(gameObject);
    }

    private void OnTriggerEnter(Collider other)
    {
        
        //VariableStatic.CanChoose = true;
        Time.timeScale = 1f;
        if (other.CompareTag("ShipModule"))
        {
            gameObject.SetActive(false);
        }
        Time.timeScale = 0;
        VariableStatic.CanChoose = false;
    }
}
