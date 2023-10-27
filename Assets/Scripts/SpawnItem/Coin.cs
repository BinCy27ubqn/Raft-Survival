using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField]
    private GameObject _player;
    [SerializeField]
    private GameObject _coinSpawn;

    [SerializeField]
    private float _distancePlayerToCoin;
    [SerializeField]
    private float _timeToSpawnCoin;

    Vector3 newOffset;
    private void Start()
    {
        StartCoroutine(Spawn(_coinSpawn));
    }

    private IEnumerator Spawn(GameObject coinSpawn)
    {
        while (true)
        {
            do
            {
                newOffset = Random.insideUnitSphere * _distancePlayerToCoin;
            } while ((newOffset.x - transform.position.x < 30 && newOffset.x - transform.position.x > -30) && (newOffset.z - transform.position.z < 30 && newOffset.z - transform.position.z > -30));

            newOffset.y = 0;
            Vector3 spawnPosition = _player.transform.position + newOffset;

            Instantiate(coinSpawn, spawnPosition, coinSpawn.transform.rotation);
            yield return new WaitForSeconds(_timeToSpawnCoin);
        }
    }

}
