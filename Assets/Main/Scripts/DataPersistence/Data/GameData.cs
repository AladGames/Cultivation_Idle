using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class GameData
{
    //Upgrades
    //Click Upgrade
    public uint clickUpgradeOwned;
    public double clickUpgradePrice;

    //Production Upgrade
    public uint productionOwned;
    public double productionUpgradePrice;

    //Scriptable Object data
    public MainData mainData;


    // the values defined in this constructor will be the default values
    // the game starts with when there's no data to load
    public GameData()
    {
        clickUpgradeOwned = 1;
        clickUpgradePrice = 10;
        productionOwned = 1;
        productionUpgradePrice = 100;
        mainData = new MainData();
    }
}
