using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinManager : MonoBehaviour
{
    [SerializeField]
    private int _coinEarn;

    private Text _coinText;

    [SerializeField]
    private GameObject _coinItem;
    private void Start()
    {
        _coinText = GameObject.Find("CoinText").GetComponent<Text>();

        if (PlayerPrefs.GetInt("IncomeCurrentLevel") == 1)
        {
            _coinEarn = 25;
        }
        else if (PlayerPrefs.GetInt("IncomeCurrentLevel") == 2)
        {
            _coinEarn = 30;
        }
        else if (PlayerPrefs.GetInt("IncomeCurrentLevel") == 3)
        {
            _coinEarn = 35;
        }
        else if (PlayerPrefs.GetInt("IncomeCurrentLevel") == 4)
        {
            _coinEarn = 40;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("ShipModule"))
        {
            Play.quantityCoinEarned += _coinEarn;
            Debug.Log(Play.quantityCoinEarned);
            GameObject UICoin = Instantiate(_coinItem, gameObject.transform.position, _coinItem.transform.rotation);
            Destroy(UICoin, 1f);

            MoneyManager._money += _coinEarn;
            PlayerPrefs.SetInt("Money", MoneyManager._money);
            _coinText.text = PlayerPrefs.GetInt("Money").ToString();
            Destroy(gameObject);
        }
    }
}
