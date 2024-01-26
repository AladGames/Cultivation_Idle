using System.Collections;
using System.Collections.Generic;
using System.Data.SqlTypes;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using static System.Net.Mime.MediaTypeNames;

public class MainGame : MonoBehaviour
{
    [Header("MainData SO")]
    [SerializeField] private MainScriptableObject mainDataSO;

    [Header("Main Texts To Modify")]
    public TMP_Text moneyText;
    public TMP_Text moneyPerSecondText;

    /*// Start is called before the first frame update
    void Start()
    {
        
    }*/

    // Update is called once per frame
    void Update()
    {
        moneyText.text = "Money : " + mainDataSO.money.ToString("F1");
        moneyPerSecondText.text = "Money/s : " + mainDataSO.moneyPerSecond.ToString("F1");
    }
}
