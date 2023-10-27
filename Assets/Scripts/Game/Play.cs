using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Play : MonoBehaviour
{
    [SerializeField]
    private List<GameObject> _choosePlayer;
    [SerializeField]
    private GameObject _body; 

    [SerializeField]
    private GameObject _protect;

    public static bool isProtected = false;
    public static bool isFirstUnit = true;

    private GameObject _mainUnit;
    [SerializeField]
    private GameObject _loseGamePanel;

    public static int quantityEnenyDie=0;
    public static int quantityCoinEarned=0;
    [SerializeField]
    private Text _textQuantityEnenyDie;
    [SerializeField]
    private Text _textQuantityCoinEarned;
    [SerializeField]
    private Text _textTimeCurrentSurvival;
    [SerializeField]
    private Text _textTimeAchievmentSurvival;

    [SerializeField]
    private AudioSource _audio;
    void Start()
    {
        _audio.Play();
        Physics.gravity = new Vector3(0,-100,0);

        Application.targetFrameRate = 60;

        VariableStatic.isMainRaft = true;
        PlayerPrefs.SetInt("IsStartGame", 1);

        if (PlayerPrefs.GetInt("CharacterSelection") == 1){
            _mainUnit = Instantiate(_choosePlayer[0], _body.transform.parent);
        }else if(PlayerPrefs.GetInt("CharacterSelection") == 2)
        {
            _mainUnit = Instantiate(_choosePlayer[1], _body.transform.parent);
        }else if(PlayerPrefs.GetInt("CharacterSelection") == 3)
        {
            _mainUnit = Instantiate(_choosePlayer[2], _body.transform.parent);
        }else if(PlayerPrefs.GetInt("CharacterSelection") == 4)
        {
            _mainUnit = Instantiate(_choosePlayer[3], _body.transform.parent);
        }else if(PlayerPrefs.GetInt("CharacterSelection") == 5)
        {
            _mainUnit = Instantiate(_choosePlayer[4], _body.transform.parent);
        }else if(PlayerPrefs.GetInt("CharacterSelection") == 6)
        {
            _mainUnit = Instantiate(_choosePlayer[5], _body.transform.parent);
        }else if(PlayerPrefs.GetInt("CharacterSelection") == 7)
        {
            _mainUnit = Instantiate(_choosePlayer[6], _body.transform.parent);
        }


        if(PlayerPrefs.GetInt("CharacterSelection") == 1)
        {
            VariableStatic.numberCard.Add(8);
        }else if (PlayerPrefs.GetInt("CharacterSelection") == 2)
        {
            VariableStatic.numberCard.Add(3);
        }else if (PlayerPrefs.GetInt("CharacterSelection") == 3)
        {
            VariableStatic.numberCard.Add(12);
        }else if (PlayerPrefs.GetInt("CharacterSelection") == 4)
        {
            VariableStatic.numberCard.Add(0);
        }else if (PlayerPrefs.GetInt("CharacterSelection") == 5)
        {
            VariableStatic.numberCard.Add(9);
        }else if (PlayerPrefs.GetInt("CharacterSelection") == 6)
        {
            VariableStatic.numberCard.Add(7);
        }else if (PlayerPrefs.GetInt("CharacterSelection") == 7)
        {
            VariableStatic.numberCard.Add(11);
        }

        LightingHealth.forceFieldIsDie = false;
        VariableStatic.isBuildForceField = false;
    }

    private void Update()
    {
        if(isProtected == true)
        {
            _protect.SetActive(true);
        }
        else
        {
            _protect.SetActive(false);
        }

        if(_mainUnit == null)
        {
            _loseGamePanel.SetActive(true);
            Time.timeScale = 0;
        }

        _textQuantityEnenyDie.text = quantityEnenyDie.ToString();
        _textQuantityCoinEarned.text = quantityCoinEarned.ToString();
        _textTimeAchievmentSurvival.text = _textTimeCurrentSurvival.text;
    }
}
