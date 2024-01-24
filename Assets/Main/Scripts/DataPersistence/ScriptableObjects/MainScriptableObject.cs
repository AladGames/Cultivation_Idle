using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "MainScriptableObject", menuName = "MainScriptableObject", order = 1)]
public class MainScriptableObject : ScriptableObject
{
    public double money;
    public uint clickPower;
    public uint moneyPerSecond;
}
