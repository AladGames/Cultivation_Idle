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
    public uint productionUpgradeLevel;
 

    // Update is called once per frame
    void Update()
    {
        text.text = "Hire a worker (Passive income)\n" +
            "Level : " + productionUpgradeLevel.ToString() + "\n" +
            "Price : " + productionUpgradePrice.ToString("F0");
        mainDataSO.money += mainDataSO.moneyPerSecond * Time.deltaTime;
    }

    public override void OnClick()
    {
        if (mainDataSO.money >= productionUpgradePrice)
        {
            mainDataSO.money -= productionUpgradePrice;
            productionUpgradeLevel++;
            productionUpgradePrice *= 2.5;
            mainDataSO.moneyPerSecond++;
        }
    }

    public override void SaveData(GameData data)
    {
        data.productionUpgradePrice = this.productionUpgradePrice;
        data.productionUpgradeLevel = this.productionUpgradeLevel;
        
        data.mainData.money = mainDataSO.money;
        data.mainData.moneyPerSecond = mainDataSO.moneyPerSecond;
    }
    
    public override void LoadData(GameData data)
    {
        this.productionUpgradePrice = data.productionUpgradePrice;
        this.productionUpgradeLevel = data.productionUpgradeLevel;

        mainDataSO.money = data.mainData.money;
        mainDataSO.moneyPerSecond = data.mainData.moneyPerSecond;
    }
}
