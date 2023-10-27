using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExperienceUnit : MonoBehaviour
{
    [SerializeField]
    private LevelManager _levelManager;
    
    void Start()
    {
        LevelManager.increaseExperience = 1.2f;
        _levelManager = GameObject.Find("PlayerRaft").GetComponent<LevelManager>();
        _levelManager._plusExperiencePoint = _levelManager._plusExperiencePoint * LevelManager.increaseExperience;
    }
}
