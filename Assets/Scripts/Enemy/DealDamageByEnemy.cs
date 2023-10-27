using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DealDamageByEnemy : MonoBehaviour
{
    //[SerializeField]
    private PlayerHealth _playerHealth;
    private ThrusterHealth _thrusterHealth;
    private LightingHealth _lightingHealth;
    private DamageHealth _damageHealth;
    private HealthModuleHealth _healthModuleHealth;
    [SerializeField]
    public float _damage;
    private float _timeInterval;

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("ShipModule") && Time.time - _timeInterval > 1f)
        {
            _playerHealth = other.GetComponent<PlayerHealth>();

            if(_playerHealth != null)
            {
                _playerHealth.TakeDamage(_damage);
            }
            //_timeInterval = Time.time;

            _thrusterHealth = other.GetComponent<ThrusterHealth>();

            if (_thrusterHealth != null)
            {
                _thrusterHealth.TakeDamage(_damage);
                
            }

            _lightingHealth = other.GetComponent<LightingHealth>();
            if (_lightingHealth != null)
            {
                _lightingHealth.TakeDamage(_damage);
                
            }
            
            _damageHealth = other.GetComponent<DamageHealth>();
            if (_damageHealth != null)
            {
                _damageHealth.TakeDamage(_damage);
                
            }
            _healthModuleHealth = other.GetComponent<HealthModuleHealth>();
            if (_healthModuleHealth != null)
            {
                _healthModuleHealth.TakeDamage(_damage);
                
            }



            _timeInterval = Time.time;
        }
    }

}
