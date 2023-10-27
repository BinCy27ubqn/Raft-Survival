using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeCuter : MonoBehaviour
{
    [SerializeField]
    private Animation _anim;
    [SerializeField]
    private GameObject _cylinder;
    [SerializeField]
    private GameObject _healUI;
    [SerializeField]
    private GameObject _root;


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Tree"))
        {
            _anim.Play();
            Destroy(other.gameObject);

            float z = Random.Range(30, 90);
            _cylinder.transform.Rotate(0, 0, z);
            GameObject cylinder = Instantiate(_cylinder, gameObject.transform.position + new Vector3(0,0.76f,0), _cylinder.transform.rotation);
            Destroy(cylinder, 1);
            GameObject healing = Instantiate(_healUI, gameObject.transform.position + new Vector3(0,2,0.5f), _healUI.transform.rotation);
            Destroy(healing, 1);
            GameObject root = Instantiate(_root, other.transform.position, _root.transform.rotation);
        }
    }
}
