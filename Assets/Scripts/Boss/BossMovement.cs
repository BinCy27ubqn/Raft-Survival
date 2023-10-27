using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BossMovement : MonoBehaviour
{
    private GameObject _targetPlayer;
    public float _speed;
    [SerializeField]
    private float _distanceToBossLookAtPlayer;
    private GameObject bullet;

    [SerializeField]
    private Animator _animator;

    public static bool isFollowPlayer = true;
    public bool isWormBoss;

    [SerializeField]
    private bool isHaveAnim;
    
    private float distance;

    void Start()
    {
        if(isWormBoss == false)
        {
            _targetPlayer = GameObject.Find("PlayerPoint");
        }
        
    }

    void Update()
    {
        if (isWormBoss == true)
        {
            _targetPlayer = DetectionByEnemy(gameObject.transform);
        }
        float distance = Vector3.Distance(gameObject.transform.position, _targetPlayer.transform.position);
        transform.LookAt(_targetPlayer.transform, Vector3.up);

        if (distance > _distanceToBossLookAtPlayer)
        {
            isFollowPlayer = false;
            transform.Translate(Vector3.forward * Time.deltaTime * _speed);
            if (isHaveAnim == true)
            {
                _animator.SetBool("IdleToWalk", true);
            }
        }
        else
        {
            isFollowPlayer = true;
            if (isHaveAnim == true)
            {
                _animator.SetBool("IdleToWalk", false);
            }
        }
    }


    public GameObject DetectionByEnemy(Transform transform)
    {
        float distanceClosest = Mathf.Infinity;
        GameObject shipModuleClosest = null;
        GameObject[] allShip = GameObject.FindGameObjectsWithTag("ShipModule");

        foreach (GameObject ship in allShip)
        {
            float distancePlayerToBoss = (ship.transform.position - transform.position).magnitude;
            if (distancePlayerToBoss < distanceClosest)
            {
                distanceClosest = distancePlayerToBoss;
                shipModuleClosest = ship;
            }
        }

        if (shipModuleClosest != null)
        {
            distance = Vector3.Distance(transform.position, shipModuleClosest.transform.position);
            if (distance < 100f)
            {
                transform.LookAt(shipModuleClosest.transform);
            }
        }

        return shipModuleClosest;
    }
}
