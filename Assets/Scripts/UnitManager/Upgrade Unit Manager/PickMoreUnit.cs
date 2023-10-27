using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickMoreUnit : MonoBehaviour
{
    [SerializeField]
    private GameObject _left;
    [SerializeField]
    private GameObject _right;
    [SerializeField]
    private GameObject _up;
    [SerializeField]
    private GameObject _down;

    public bool isShowUpgradeUnit = true;
    void Update()
    {
        if (LevelManager.isUpgrade == true && isShowUpgradeUnit == true)
        {
            if (_left != null)
            {
                _left.SetActive(true);
            }
            if (_right != null)
            {
                _right.SetActive(true);
            }
            if (_up != null)
            {
                _up.SetActive(true);
            }
            if (_down != null)
            {
                _down.SetActive(true);
            }
            isShowUpgradeUnit = false;
        }
        if(LevelManager.isUpgrade == false)
        {
            isShowUpgradeUnit = true;
            if (_left != null)
            {
                _left.SetActive(false);
            }
            if (_right != null)
            {
                _right.SetActive(false);
            }
            if (_up != null)
            {
                _up.SetActive(false);
            }
            if (_down != null)
            {
                _down.SetActive(false);
            }
        }
    }
}
