using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    private GameObject _targetPlayer;
    [SerializeField]
    private float _speed;
    private GameObject bullet;

    private Rigidbody _rigidbody;
    [SerializeField]
    private bool _isGoldFishMovement;

    void Start()
    {
        if (_isGoldFishMovement == false)
        {
            _targetPlayer = GameObject.Find("PlayerPoint");
        }
        if(_isGoldFishMovement == true)
        {
            _rigidbody = gameObject.GetComponent<Rigidbody>();
            _rigidbody.velocity = transform.forward * _speed;
        }
    }

    void Update()
    {
        if(_isGoldFishMovement == false)
        {
            transform.LookAt(_targetPlayer.transform, Vector3.up);
            transform.Translate(Vector3.forward * Time.deltaTime * _speed);
        }
    }
}
