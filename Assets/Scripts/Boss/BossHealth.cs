using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BossHealth : MonoBehaviour
{
    [SerializeField]
    private float _health;
    [SerializeField]
    private float _maxHealth;
    [SerializeField]
    private GameObject _healthBar;

    private GameObject intanceHealth;

    private Slider slider;

    [SerializeField]
    private Animator _animator;

    [SerializeField]
    private GameObject[] _drop;

    [SerializeField]
    private Material _bossMaterial;

    private Color originalColor;
    private Color blinkColor;

    public static float elapsedTime = 0;
    private void Start()
    {
        _bossMaterial.color = new Color(1, 1, 1);
        GameObject healbarBossUI = GameObject.Find("UIHealbarBossUI");
        intanceHealth = Instantiate(_healthBar, healbarBossUI.transform.position, healbarBossUI.transform.rotation, healbarBossUI.transform.parent);

        GameObject healbarBoss = GameObject.Find("SliderHealthBoss(Clone)");
        slider = healbarBoss.GetComponent<Slider>();


        originalColor = _bossMaterial.color;
        blinkColor = new Color(255, 255, 2000);
    }

    private void Update()
    {
        slider.value = _health/ _maxHealth;
    }

    public static float _damgeTaken;
    public void TakeDamage(float damage)
    {
        StartCoroutine(BlinkEffect(0.1f));
        _health -= damage;

        _damgeTaken = damage;
        if (_health <= 0)
        {
            _animator.SetBool("IsDie", true);
            Invoke("Die", 1.5f);
        }
    }

    IEnumerator BlinkEffect(float blinkInterval)
    {
            _bossMaterial.color = blinkColor;
            yield return new WaitForSeconds(blinkInterval);
            _bossMaterial.color = originalColor;
       
    }

    private void Die()
    {
        elapsedTime = Time.timeSinceLevelLoad - SpawnEnemy.spawnTime;
        Instantiate(_drop[0], gameObject.transform.position + new Vector3(0.7f,0.7f), _drop[0].transform.rotation);
        Instantiate(_drop[1], gameObject.transform.position, _drop[0].transform.rotation);
        Instantiate(_drop[2], gameObject.transform.position + new Vector3(-0.7f, 0.7f), _drop[0].transform.rotation);
        Timer._timeBossDie = Timer._curentTime + 2;
        SpawnEnemy.bossIsApper = false;
        SpawnEnemy.boss1Die = true;
        Destroy(intanceHealth);
        Destroy(gameObject);
    }
}
