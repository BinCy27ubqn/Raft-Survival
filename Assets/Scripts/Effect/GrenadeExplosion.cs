using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrenadeExplosion : MonoBehaviour
{
    void Start()
    {
        Destroy(gameObject, 2);
    }
}
