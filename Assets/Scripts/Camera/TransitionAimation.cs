using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransitionAimation : MonoBehaviour
{
    private Animator _anim;
    void Start()
    {
        _anim = GameObject.Find("Main Camera").GetComponent<Animator>();
    }

    public void RotateCam(bool IsRotate)
    {
        _anim.SetBool("IsRotate", IsRotate);
    }
}
