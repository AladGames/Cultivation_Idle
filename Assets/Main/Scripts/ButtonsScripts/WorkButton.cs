using System.Collections;
using System.Collections.Generic;
using System.Data.SqlTypes;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class WorkButton : Button
{
    [Header("MainData SO")]
    [SerializeField] private MainScriptableObject mainDataSO;

    public TMP_Text text;

    void Update()
    {
        text.text = "Money : " + mainDataSO.money.ToString("F0");
    }

    public override void OnClick()
    {
        mainDataSO.money += mainDataSO.clickPower;
    }

    public override void SaveData(GameData data)
    {
        data.mainData.money = mainDataSO.money;
    }

    public override void LoadData(GameData data)
    {
        mainDataSO.money = data.mainData.money;
    }
}
