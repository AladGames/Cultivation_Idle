using System.Collections;
using System.Collections.Generic;
using System.Data.SqlTypes;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class ClickUpgradeButton : Button
{
    [Header("MainData SO")]
    [SerializeField] private MainScriptableObject mainDataSO;

    public TMP_Text text;

    [Header("Local Values")]
    public double clickUpgradePrice;
    public uint clickUpgradeOwned;

    void Update()
    {
        text.text = "Buy a tool (x2 Work efficiency)\n" +
            "Level : " + this.clickUpgradeOwned.ToString() + "\n" +
            "Price : " + this.clickUpgradePrice.ToString("F0");
    }

    public override void OnClick()
    {
        if (mainDataSO.money >= this.clickUpgradePrice)
        {
            mainDataSO.money -= this.clickUpgradePrice;
            this.clickUpgradeOwned++;
            //costNext = costBase × (rategrowth)^owned
            this.clickUpgradePrice = 10 * Math.Pow(1.5, this.clickUpgradeOwned);
            //productionTotal = (productionBase × owned) × multipliers
            mainDataSO.clickPower = this.clickUpgradeOwned;
        }
    }

    public override void SaveData(GameData data)
    {
        data.clickUpgradeOwned = this.clickUpgradeOwned;
        data.clickUpgradePrice = this.clickUpgradePrice;
        
        data.mainData.money = mainDataSO.money;
        data.mainData.clickPower = mainDataSO.clickPower;        
    }

    public override void LoadData(GameData data)
    {
        this.clickUpgradeOwned = data.clickUpgradeOwned;
        this.clickUpgradePrice = data.clickUpgradePrice;

        mainDataSO.money = data.mainData.money;
        mainDataSO.clickPower = data.mainData.clickPower;
    }

    
}
