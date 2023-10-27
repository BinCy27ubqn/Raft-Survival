using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpiderBoss : MonoBehaviour
{
    private float _timeInterval;
    [SerializeField]
    private GameObject _bossBullet;
    [SerializeField]
    private GameObject _bulletPlaceForward;
    [SerializeField]
    private GameObject _bulletPlaceRight;
    [SerializeField]
    private GameObject _bulletPlaceLeft;

    [SerializeField]
    private float _timeIntervalToShoot;

    private bool _canShoot3BulletForward = false;

    public float fireRate = 0.2f;
    private bool isShooting = false;
    float timeIntervalFor3bullet;

    [SerializeField]
    private AudioSource _audio;
    void Start()
    {
        _audio.Play();

        _timeInterval = Time.time;
        timeIntervalFor3bullet = Time.time;
    }

    public void InvokeDelay()
    {
        StartCoroutine(ShootBullet());
    }

    void Update()
    {
        if (Time.time - _timeInterval > _timeIntervalToShoot && BossMovement.isFollowPlayer == true)
        {
            Instantiate(_bossBullet, _bulletPlaceForward.transform.position, _bulletPlaceForward.transform.rotation);
            Instantiate(_bossBullet, _bulletPlaceRight.transform.position, _bulletPlaceRight.transform.rotation);
            Instantiate(_bossBullet, _bulletPlaceLeft.transform.position, _bulletPlaceLeft.transform.rotation);
            _timeInterval = Time.time;
        }
        if (Time.time > 3f)
        {
            _canShoot3BulletForward = true;
        }
        Debug.Log(_canShoot3BulletForward);

        if (_canShoot3BulletForward)
        {
            if (Time.time - timeIntervalFor3bullet > _timeIntervalToShoot)
            {
                StartCoroutine(ShootBullet());
                timeIntervalFor3bullet = Time.time;
            }
        }
    }   

    [SerializeField]
    private GameObject _damageUI;

    [SerializeField]
    private float _retreatDistance; 

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("TankBullet"))
        {
            Vector3 direction = transform.position - other.transform.position;
            direction.y = 0;
            //direction.Normalize();

            Vector3 newPosition = transform.position + direction * (float)_retreatDistance;
            transform.position = newPosition;
        }

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

    

    private IEnumerator ShootBullet()
    {
        if (!isShooting)
        {
            for (int i = 0; i < 3; i++)
            {
                Instantiate(_bossBullet, _bulletPlaceForward.transform.position, _bulletPlaceForward.transform.rotation);
                yield return new WaitForSeconds(fireRate);
            }
            isShooting = false;
        }
        yield return null;
    }
}
