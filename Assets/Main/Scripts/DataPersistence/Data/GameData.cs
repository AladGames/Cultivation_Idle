using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class GameData
{
    
    public double money;
    public uint clickPower;
    public uint clickUpgradeLevel;
    public double clickUpgradePrice;

    
    // the values defined in this constructor will be the default values
    // the game starts with when there's no data to load
    public GameData()
    {
        money = 0;
        clickPower = 1;
        clickUpgradeLevel = 1;
        clickUpgradePrice = 10;
    }
}
