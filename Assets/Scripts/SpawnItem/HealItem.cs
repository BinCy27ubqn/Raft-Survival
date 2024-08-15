using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealItem : MonoBehaviour
{
    [SerializeField]
    private GameObject _player;
    [SerializeField]
    private GameObject _healSpawn;

    [SerializeField]
    private float _distancePlayerToHeal;
    [SerializeField]
    private float _timeToSpawnHeal;

    Vector3 newOffset;
    private void Start()
    {
        StartCoroutine(Spawn(_healSpawn));
    }

    private IEnumerator Spawn(GameObject Spawn)
    {
        while (true)
        {
            do
            {
                newOffset = Random.insideUnitSphere * _distancePlayerToHeal;
            } while ((newOffset.x - transform.position.x < 30 && newOffset.x - transform.position.x > -30) && (newOffset.z - transform.position.z < 30 && newOffset.z - transform.position.z > -30));

            newOffset.y = 0;
            Vector3 spawnPosition = _player.transform.position + newOffset;

            Instantiate(Spawn, spawnPosition, Spawn.transform.rotation);
            yield return new WaitForSeconds(_timeToSpawnHeal);
        }
    }
}
