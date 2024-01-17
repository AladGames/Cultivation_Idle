using System.Collections;
using System.Collections.Generic;
using System.Data.SqlTypes;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MainGame : MonoBehaviour, IDataPersistence
{
    [SerializeField] private GameData gameData;
    
    public TMP_Text moneyText;
    public TMP_Text clickUpgradeText;

    /*// Start is called before the first frame update
    void Start()
    {
        
    }*/

    // Update is called once per frame
    void Update()
    {
        moneyText.text = "Money : " + gameData.money.ToString("F0");
        clickUpgradeText.text = "Buy a tool (x2 Work efficiency)\nLevel : " + gameData.clickUpgradeLevel.ToString() + "\nPrice : " + gameData.clickUpgradePrice.ToString("F0");
    }

    public void Click()
    {
        gameData.money += gameData.clickPower;
    }

    public void Upgrade()
    {
        if (gameData.money >= gameData.clickUpgradePrice)
        {
            gameData.money -= gameData.clickUpgradePrice;
            gameData.clickUpgradeLevel++;
            gameData.clickUpgradePrice *= 1.57;
            gameData.clickPower *= 2; 
        }
    }

    public void SaveData(GameData data)
    {
        data.money = gameData.money;
        data.clickUpgradePrice = gameData.clickUpgradePrice;
        
        data.clickPower = gameData.clickPower;
        data.clickUpgradeLevel = gameData.clickUpgradeLevel;
    }

    public void LoadData(GameData data)
    {
        gameData.money = data.money;
        gameData.clickUpgradeLevel = data.clickUpgradeLevel;
        
        gameData.clickUpgradePrice = data.clickUpgradePrice;
        gameData.clickPower = data.clickPower;

    }
}
