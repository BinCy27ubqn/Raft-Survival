using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClosestEnemy : MonoBehaviour
{
    private float distance;

    public float DetectionByPlayer(Transform transform)
    {
        float distanceClosest = Mathf.Infinity;
        EnemyMovement enemyClosest = null;
        EnemyMovement[] allEnemies = GameObject.FindObjectsOfType<EnemyMovement>();

        foreach (EnemyMovement currentEnemy in allEnemies)
        {
            float distanceEnemyToPLayer = (currentEnemy.transform.position - transform.position).magnitude;
            if (distanceEnemyToPLayer < distanceClosest)
            {
                distanceClosest = distanceEnemyToPLayer;
                enemyClosest = currentEnemy;
            }
        }

        if (enemyClosest != null)
        {
            distance = Vector3.Distance(transform.position, enemyClosest.transform.position);
            if (distance < 8.5f)
            {
                transform.LookAt(enemyClosest.transform);
            }
        }

        return distance;
    }

}
