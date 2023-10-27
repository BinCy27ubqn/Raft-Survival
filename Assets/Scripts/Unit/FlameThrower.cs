using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlameThrower : MonoBehaviour
{
    [SerializeField]
    private GameObject _flamePlace;
    private float _distance;

    ClosestEnemy closestEnemy;
    private void Start()
    {
        closestEnemy = GameObject.FindObjectOfType<ClosestEnemy>();
    }

    private void Update()
    {
        if(closestEnemy != null)
        {
            _distance = closestEnemy.DetectionByPlayer(gameObject.transform);
            if (_distance < 8)
            {
                ActiveFlame();
            }
            else
            {
                DisableFlame();
            }
        }
        DetectionBoss();
    }

    public void ActiveFlame()
    {
        _flamePlace.SetActive(true);
    }
    public void DisableFlame()
    {
        _flamePlace.SetActive(false);
    }

    public void DetectionBoss()
    {
        GameObject boss = GameObject.FindGameObjectWithTag("Boss");

        if (boss != null)
        {
            float distance = Vector3.Distance(transform.position, boss.transform.position);
           
            Vector3 direction = boss.transform.position - transform.position;
            transform.rotation = Quaternion.LookRotation(direction, Vector3.up);
            if (distance < 12f)
            {
                ActiveFlame();
            }
            else
            {
                DisableFlame();
            }
        }
    }
}
