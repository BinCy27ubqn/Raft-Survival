using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagnetItem : MonoBehaviour
{
    [SerializeField]
    private GameObject _player;
    [SerializeField]
    private GameObject _magnetSpawn;

    [SerializeField]
    private float _distancePlayerToCoin;
    [SerializeField]
    private float _timeToSpawnMagnet;

    Vector3 newOffset;
    private void Start()
    {
        StartCoroutine(Spawn(_magnetSpawn));
    }

    private IEnumerator Spawn(GameObject Spawn)
    {
        while (true)
        {
            do
            {
                newOffset = Random.insideUnitSphere * _distancePlayerToCoin;
            } while ((newOffset.x - transform.position.x < 30 && newOffset.x - transform.position.x > -30) && (newOffset.z - transform.position.z < 30 && newOffset.z - transform.position.z > -30));

            newOffset.y = 0;
            Vector3 spawnPosition = _player.transform.position + newOffset;

            Instantiate(Spawn, spawnPosition, Spawn.transform.rotation);
            yield return new WaitForSeconds(_timeToSpawnMagnet);
        }
    }
}
