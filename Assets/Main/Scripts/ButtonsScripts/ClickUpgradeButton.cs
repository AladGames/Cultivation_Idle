using System.Collections;
using System.Collections.Generic;
using System.Data.SqlTypes;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ClickUpgradeButton : Button
{
    [Header("MainData SO")]
    [SerializeField] private MainScriptableObject mainDataSO;

    public TMP_Text text;

    [Header("Local Values")]
    public double clickUpgradePrice;
    public uint clickUpgradeLevel;

    void Update()
    {
        text.text = "Buy a tool (x2 Work efficiency)\n" +
            "Level : " + clickUpgradeLevel.ToString() + "\n" +
            "Price : " + clickUpgradePrice.ToString("F0");
    }

    public override void OnClick()
    {
        if (mainDataSO.money >= clickUpgradePrice)
        {
            mainDataSO.money -= clickUpgradePrice;
            clickUpgradeLevel++;
            clickUpgradePrice *= 2.5;
            mainDataSO.clickPower *= 2;
        }
    }

    public override void SaveData(GameData data)
    {
        data.clickUpgradeLevel = this.clickUpgradeLevel;
        data.clickUpgradePrice = this.clickUpgradePrice;
        
        data.mainData.money = mainDataSO.money;
        data.mainData.clickPower = mainDataSO.clickPower;        
    }

    public override void LoadData(GameData data)
    {
        this.clickUpgradeLevel = data.clickUpgradeLevel;
        this.clickUpgradePrice = data.clickUpgradePrice;

        mainDataSO.money = data.mainData.money;
        mainDataSO.clickPower = data.mainData.clickPower;
    }

    
}
