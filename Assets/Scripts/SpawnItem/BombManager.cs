using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombManager : MonoBehaviour
{
    [SerializeField]
    private float _dealDamage;
    [SerializeField]
    private GameObject _damageUI;

    [SerializeField]
    private GameObject _bombItem;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("ShipModule"))
        {
            GameObject UIBomb = Instantiate(_bombItem, gameObject.transform.position, _bombItem.transform.rotation);
            Destroy(UIBomb, 1f);

            EnemyHealth[] enemyHealth = FindObjectsOfType<EnemyHealth>();

            foreach(EnemyHealth enemy in enemyHealth)
            {
                enemy.TakeDamage(_dealDamage);
                GameObject instantiate = Instantiate(_damageUI, enemy.transform.position, _damageUI.transform.rotation);
                Destroy(instantiate, 0.5f);
            }
            Destroy(gameObject);
        }
    }
}
