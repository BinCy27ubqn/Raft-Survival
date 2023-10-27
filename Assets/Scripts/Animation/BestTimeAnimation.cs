using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BestTimeAnimation : MonoBehaviour
{
    [SerializeField]
    private Animation _anim;
    void Start()
    {
        _anim.Play();
    }
}
