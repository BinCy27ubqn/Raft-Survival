using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Magnet : MonoBehaviour
{
    public float _radius;
    [SerializeField]
    private float _magnetForce;

    public static bool isSucked;

    [SerializeField]
    private MagneLevelUp _MagneLevelUp;

    private void Update()
    {
        if(_MagneLevelUp._currentLevel == 2)
        {
            _radius = _MagneLevelUp.increaseRadius;
        }
        if(_MagneLevelUp._currentLevel == 3)
        {
            _radius = _MagneLevelUp.increaseRadius;
        }
        if(_MagneLevelUp._currentLevel == 4)
        {
            _radius = _MagneLevelUp.increaseRadius;
        }

        Collider[] colliders = Physics.OverlapSphere(transform.position, _radius);

        foreach(Collider col in colliders)
        {
            if (col.CompareTag("Experience"))
            {
                Rigidbody rb = col.GetComponent<Rigidbody>();
                if(rb != null)
                {
                    Vector3 direction = transform.position - col.transform.position;
                    rb.AddForce(direction.normalized * _magnetForce);
                }
            }
            if (col.CompareTag("Bomb") || col.CompareTag("Heal") || col.CompareTag("Coin") || col.CompareTag("Magnet"))
            {
                Rigidbody rb = col.GetComponent<Rigidbody>();
                if(rb != null)
                {
                    Vector3 direction = transform.position - col.transform.position;
                    rb.AddForce(direction.normalized * _magnetForce);
                }
            }
        }

    }

}
