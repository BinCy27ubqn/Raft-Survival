using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Earthworm : MonoBehaviour
{
    [SerializeField]
    private Animator _animator;
    [SerializeField]
    private float _distanceToAttackPlayer;
    [SerializeField]
    private float _speedAfterDetectPlayer;
    [SerializeField]
    private BossMovement _bossMovement;
    [SerializeField]
    private float _dealDamage;

    private GameObject _player;

    private float _timeInterval;


    [SerializeField]
    private AudioSource _audio;
    void Start()
    {
        _audio.Play();
        _timeInterval = Time.time;
        
    }
    float distance;
    void Update()
    {
        _player = _bossMovement.DetectionByEnemy(gameObject.transform);
        if (_player != null)
        {
            distance = Vector3.Distance(gameObject.transform.position, _player.transform.position);
        }
        if(distance < _distanceToAttackPlayer)
        {
            _bossMovement._speed = _speedAfterDetectPlayer;
            _animator.SetBool("IsDetectPlayer", true);
            if(distance < 6)
            {
                _animator.SetBool("IsAttack", true);
            }
            else
            {
                _animator.SetBool("IsAttack", false);
            }
        }
        else
        {
            _bossMovement._speed = 4;
            _animator.SetBool("IsDetectPlayer", false);
        }
    }

    [SerializeField]
    private GameObject _damageUI;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Bullet"))
        {
            DispayDamgageTaken();
        }

        
    }

    public void DispayDamgageTaken()
    {
        GameObject takeDamageUI = Instantiate(_damageUI, gameObject.transform.position + new Vector3(0, 1.5f, 0), _damageUI.transform.rotation);
        Destroy(takeDamageUI, 0.5f);
    }
}
