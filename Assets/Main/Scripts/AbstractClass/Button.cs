using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public abstract class Button : MonoBehaviour, IDataPersistence
{
    //Abstract class for all buttons
    //Abstract class methods
    public abstract void OnClick();    
    public abstract void SaveData(GameData data);
    public abstract void LoadData(GameData data);
}
