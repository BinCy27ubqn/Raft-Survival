using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DamageHealth : MonoBehaviour
{
    [SerializeField]
    public float _health;
    public float _currentHealth;

    [SerializeField]
    private Slider _sliderHealthBar;
    [SerializeField]
    private GameObject _HealthBar;

    private Coroutine _healthBarCoroutine;

    public static bool damageIsDie;

    [SerializeField]
    private GameObject _particleSystem;

    private void Start()
    {
        _health = HealthManager.health;
        _currentHealth = _health;
    }

    private void Update()
    {
        if (HealthUnit.healthIsBuild == true)
        {
            if (HealthManager.isIncresaHealth == true)
            {
                _health = HealthManager.increaseHealth;
                Invoke("Invinsible", 0.5f);
                _currentHealth = _health;
            }

        }
        if (HealthModuleHealth.healthIsDie == true)
        {
            _health = HealthManager.health;
            HealthUnit.healthIsBuild = false;
            _currentHealth = _health;
        }
        _sliderHealthBar.value = _currentHealth / _health;
    }

    public void Invinsible()
    {
        HealthManager.isIncresaHealth = false;
    }

    public void TakeDamage(float damage)
    {
        _currentHealth -= damage;

        if (_currentHealth <= 0)
        {
            damageIsDie = true;
            Invoke("Die", 0.5f);
        }

        ShowHealthBar();
    }

    public void ShowHealthBar()
    {
        if (_healthBarCoroutine != null)
        {
            StopCoroutine(_healthBarCoroutine);
        }

        _healthBarCoroutine = StartCoroutine(DisplayHealthBarForDuration());
    }

    private IEnumerator DisplayHealthBarForDuration()
    {
        _HealthBar.SetActive(true);
        yield return new WaitForSeconds(2f);

        _HealthBar.SetActive(false);

    }

    private void Die()
    {
        GameObject particleDie = Instantiate(_particleSystem, gameObject.transform.position, _particleSystem.transform.rotation);
        Destroy(particleDie, 1);
        Destroy(gameObject);
    }
}
