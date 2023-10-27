using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveByPlayerPrefs : MonoBehaviour
{
    private void Awake()
    {
        if(PlayerPrefs.GetInt("LevelTurret") == 0){
            PlayerPrefs.SetInt("LevelTurret", 1);
        }
        if(PlayerPrefs.GetInt("LevelTank") == 0){
            PlayerPrefs.SetInt("LevelTank", 1);
        }
        if(PlayerPrefs.GetInt("LevelSoldier") == 0){
            PlayerPrefs.SetInt("LevelSoldier", 1);
        }
        if(PlayerPrefs.GetInt("LevelRocketTurret") == 0){
            PlayerPrefs.SetInt("LevelRocketTurret", 1);
        }
        if(PlayerPrefs.GetInt("LevelForceField") == 0){
            PlayerPrefs.SetInt("LevelForceField", 1);
        }
        if(PlayerPrefs.GetInt("LevelFlameThrower") == 0){
            PlayerPrefs.SetInt("LevelFlameThrower", 1);
        }
        if(PlayerPrefs.GetInt("LevelAirport") == 0){
            PlayerPrefs.SetInt("LevelAirport", 1);
        }


        if (PlayerPrefs.GetInt("IncomeUpgradePrice") == 0)
        {
            PlayerPrefs.SetInt("IncomeUpgradePrice", 100);
        }
        if (PlayerPrefs.GetInt("IncomeCurrentLevel") == 0)
        {
            PlayerPrefs.SetInt("IncomeCurrentLevel", 1);
        }
        if (PlayerPrefs.GetInt("HealthUpgradePrice") == 0)
        {
            PlayerPrefs.SetInt("HealthUpgradePrice", 100);
        }
        if (PlayerPrefs.GetInt("HealthCurrentLevel") == 0)
        {
            PlayerPrefs.SetInt("HealthCurrentLevel", 1);
        }
        if (PlayerPrefs.GetInt("DamageUpgradePrice") == 0)
        {
            PlayerPrefs.SetInt("DamageUpgradePrice", 150);
        }
        if (PlayerPrefs.GetInt("DamageCurrentLevel") == 0)
        {
            PlayerPrefs.SetInt("DamageCurrentLevel", 1);
        }


        if (PlayerPrefs.GetInt("Color0") == 0)
        {
            PlayerPrefs.SetInt("Color0", 1);
        }
        if (PlayerPrefs.GetInt("ChooseColor") == 0)
        {
            PlayerPrefs.SetInt("ChooseColor", 1);
        }
        if (PlayerPrefs.GetInt("CharacterSelection") == 0)
        {
            PlayerPrefs.SetInt("CharacterSelection", 1);
        }

        PlayerPrefs.Save();
    }
}
