using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapSpawn : MonoBehaviour
{
    private GameObject _player;

    [SerializeField]
    private float _distanceToSpawn;
    [SerializeField]
    private GameObject _map;

    private GameObject _instanceMap;
    private GameObject _newMap;
    private GameObject _oldMap;

    [SerializeField]
    private GameObject[] _treePrefabs;

    private GameObject[] _treeInstances;

    private void Start()
    {
        _player = GameObject.Find("PlayerRaft");
        _instanceMap = Instantiate(_map, new Vector3(0,-0.5f,0), _map.transform.rotation);
        InitializeTree();
    }

    private void Update()
    {
        float distance = Vector3.Distance(_instanceMap.transform.position,_player.transform.position);
        if (distance > _distanceToSpawn)
        {
            _oldMap = _instanceMap;
            Destroy(_oldMap);
               _newMap = Instantiate(_map, _player.transform.position - new Vector3(0,1,0), _map.transform.rotation);
            _instanceMap = _newMap;
        }


        foreach(var tree in _treeInstances)
        {
            if(tree!= null)
            {
                float dis = Vector3.Distance(_player.transform.position, tree.transform.position);
                if (dis > 50)
                {
                    Destroy(tree);
                }
            }
                
        }



        for (int i = 0; i < _treeInstances.Length; i++)
        {
            if (_treeInstances[i] == null)
            {
                Vector3 randomPosition = RandomPosition();
                _treeInstances[i] = Instantiate(_treePrefabs[Random.Range(0, _treePrefabs.Length)], randomPosition, Quaternion.identity);
            }
        }
    }


    
    public void InitializeTree()
    {
        _treeInstances = new GameObject[_treePrefabs.Length];

        _treeInstances[0] = Instantiate(_treePrefabs[0], new Vector3(4.8f, -0, 3.5f), Quaternion.identity);
        _treeInstances[1] = Instantiate(_treePrefabs[1], new Vector3(-14.7f, -0, -15.1f), Quaternion.identity);
        _treeInstances[2] = Instantiate(_treePrefabs[2], new Vector3(-16.3f, -0, 16.2f), Quaternion.identity);
        _treeInstances[3] = Instantiate(_treePrefabs[3], new Vector3(13, -0, 21), Quaternion.identity);
        _treeInstances[4] = Instantiate(_treePrefabs[4], new Vector3(-34.4f, -0, -31.3f), Quaternion.identity);
        _treeInstances[5] = Instantiate(_treePrefabs[5], new Vector3(-38.4f, -0, -3.3f), Quaternion.identity);
        _treeInstances[6] = Instantiate(_treePrefabs[6], new Vector3(8.3f, -0, -31.3f), Quaternion.identity);
    }

    public Vector3 RandomPosition()
    {
        float radius = Random.Range(50 , 52);
        float angle = Random.Range(0, 360);
        Vector3 randomPosition = _player.transform.position + Quaternion.Euler(0, angle, 0) * Vector3.forward * radius;
        randomPosition.y = 0;
        return randomPosition;
    }
}
