using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagnetItemManager : MonoBehaviour
{
    private GameObject _player;

    [SerializeField]
    private float _magnetForce;
    [SerializeField]
    private float _radius;

    [SerializeField]
    private GameObject _magnetItem;

    public static bool magnetItemCall = false;
    private void Start()
    {
        _player = GameObject.Find("PlayerRaft");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("ShipModule"))
        {
            magnetItemCall = true;

            Collider[] colliders = Physics.OverlapSphere(transform.position, _radius);

            foreach (Collider col in colliders)
            {
                if (col.CompareTag("Experience"))
                {
                    Rigidbody rb = col.GetComponent<Rigidbody>();
                    if (rb != null)
                    {
                        Vector3 direction = transform.position - col.transform.position;
                        rb.AddForce(direction.normalized * _magnetForce);
                    }
                }
            }

            GameObject UIMagnet = Instantiate(_magnetItem, gameObject.transform.position, _magnetItem.transform.rotation);
            Destroy(UIMagnet, 1f);

            Destroy(gameObject);
        }
    }
}
