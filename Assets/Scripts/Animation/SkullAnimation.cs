using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkullAnimation : MonoBehaviour
{
    private Animator _mainAnimation;

    /*[SerializeField]
    private GameObject _damageUI;

    public void DispayDamgageTaken()
    {
        GameObject takeDamageUI = Instantiate(_damageUI, gameObject.transform.position, _damageUI.transform.rotation);
        Destroy(takeDamageUI, 0.5f);
    }*/


    public void Proe()
    {
        Destroy(gameObject);
    }
}
