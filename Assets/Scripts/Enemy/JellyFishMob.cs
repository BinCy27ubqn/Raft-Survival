using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JellyFishMob : MonoBehaviour
{
    private float _timeInterval;
    [SerializeField]
    private GameObject _mobBullet;
    [SerializeField]
    private GameObject _bulletPlace;
    [SerializeField]
    private Animator _anim;

    void Start()
    {
        _timeInterval = Time.time;
    }

    void Update()
    {
        if(Time.time - _timeInterval > 2f)
        {
            _anim.SetBool("IsAttack", true);
            Instantiate(_mobBullet, _bulletPlace.transform.position, _bulletPlace.transform.rotation);
            _timeInterval = Time.time;
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
