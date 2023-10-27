using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WormBossMovement : MonoBehaviour
{
    private GameObject _targetPlayer;
    [SerializeField]
    private float _speed;
    [SerializeField]
    private float _distanceToBossLookAtPlayer;
    private GameObject bullet;

    [SerializeField]
    private Animator _animator;

    public static bool isFollowPlayer = true;
    void Start()
    {
        _targetPlayer = GameObject.Find("WornTagetPoint");
    }

    void Update()
    {
        float distance = Vector3.Distance(gameObject.transform.position, _targetPlayer.transform.position);
        transform.LookAt(_targetPlayer.transform, Vector3.up);

        if (distance > _distanceToBossLookAtPlayer)
        {
            isFollowPlayer = false;
            transform.Translate(Vector3.forward * Time.deltaTime * _speed);
            _animator.SetBool("IdleToWalk", true);
        }
        else
        {
            isFollowPlayer = true;
            _animator.SetBool("IdleToWalk", false);
        }
    }
}
