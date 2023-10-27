using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    [SerializeField]
    private GameObject _loadingPanel;
    [SerializeField]
    private GameObject _upgradeButton;

    [SerializeField]
    private Animator anim;

    public void StarttingGame()
    {
        Invoke("Loading", 0.18f);
        Invoke("StartG", 2f);
        anim.enabled = true;
    }

    public void StartG()
    {
        SceneManager.LoadScene("MainScene");
    }

    public void Loading()
    {
        _loadingPanel.SetActive(true);
        _upgradeButton.SetActive(false);
    }
}
