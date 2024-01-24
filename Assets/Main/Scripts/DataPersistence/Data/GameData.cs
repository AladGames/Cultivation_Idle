using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class GameData
{
    //Upgrades
    //Click Upgrade
    public uint clickUpgradeLevel;
    public double clickUpgradePrice;

    //Production Upgrade
    public uint productionUpgradeLevel;
    public double productionUpgradePrice;

    //Scriptable Object data
    public MainData mainData;


    // the values defined in this constructor will be the default values
    // the game starts with when there's no data to load
    public GameData()
    {
        clickUpgradeLevel = 1;
        clickUpgradePrice = 10;
        productionUpgradeLevel = 1;
        productionUpgradePrice = 500;
        mainData = new MainData();
    }
}
