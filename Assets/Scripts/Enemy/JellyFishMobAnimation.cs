using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JellyFishMobAnimation : MonoBehaviour
{
    [SerializeField]
    private Animator _anim;

    public void Animation()
    {
        _anim.SetBool("IsAttack", false);
    }
    
}
