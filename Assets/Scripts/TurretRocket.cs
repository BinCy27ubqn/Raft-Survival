using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretRocket : MonoBehaviour
{
    [SerializeField]
    private float _timeRotation;

    [SerializeField]
    private Transform _shootPoint1;
    [SerializeField]
    private Transform _shootPoint2;
    [SerializeField]
    private GameObject _rocketBullet;
    private float _timeInterval;

    private void Start()
    {
        _timeInterval = Time.time;
    }

    void Update()
    {
        transform.Rotate(0, _timeRotation * Time.deltaTime, 0);

        if (Time.time - _timeInterval > 1f)
        {
            Instantiate(_rocketBullet, _shootPoint1.position,transform.rotation).SetActive(true);
            Instantiate(_rocketBullet, _shootPoint2.position,transform.rotation).SetActive(true);
            _timeInterval = Time.time;
        }
    }
}
