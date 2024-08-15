using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpItem : MonoBehaviour
{
    [SerializeField]
    private float _radius;
    [SerializeField]
    private GameObject _magnet;
    void Start()
    {
        Vector3 currentPosition = transform.position;
        currentPosition.y = 0.5f;
        transform.position = currentPosition;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("ShipModule"))
        {
            Destroy(gameObject);
            
        }
    }
}
