using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ProductionUpgradeButton : Button
{
    [Header("MainData SO")]
    [SerializeField] private MainScriptableObject mainDataSO;

    public TMP_Text text;

    [Header("Local Values")]
    public double productionUpgradePrice;
    public uint productionOwned;
 

    // Update is called once per frame
    void Update()
    {
        text.text = "Hire a worker (Passive income)\n" +
            "Level : " + this.productionOwned.ToString() + "\n" +
            "Price : " + this.productionUpgradePrice.ToString("F0");
        mainDataSO.money += mainDataSO.moneyPerSecond * Time.deltaTime;
    }

    public override void OnClick()
    {
        if (mainDataSO.money >= this.productionUpgradePrice)
        {
            mainDataSO.money -= this.productionUpgradePrice;
            this.productionOwned++;
            //costNext = costBase × (rategrowth)^owned
            this.productionUpgradePrice = 100 * Math.Pow(1.07, this.productionOwned);
            //productionTotal = (productionBase × owned) × multipliers
            mainDataSO.moneyPerSecond = (2 * this.productionOwned);
        }
    }

    public override void SaveData(GameData data)
    {
        data.productionUpgradePrice = this.productionUpgradePrice;
        data.productionOwned = this.productionOwned;
        
        data.mainData.money = mainDataSO.money;
        data.mainData.moneyPerSecond = mainDataSO.moneyPerSecond;
    }
    
    public override void LoadData(GameData data)
    {
        this.productionUpgradePrice = data.productionUpgradePrice;
        this.productionOwned = data.productionOwned;

        mainDataSO.money = data.mainData.money;
        mainDataSO.moneyPerSecond = data.mainData.moneyPerSecond;
    }
}
