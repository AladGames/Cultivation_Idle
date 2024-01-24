using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class MainData
{
    public double money;
    public uint clickPower;
    public uint moneyPerSecond;

    public MainData()
    {
        money = 0;
        clickPower = 1;
        moneyPerSecond = 0;
    }
}
