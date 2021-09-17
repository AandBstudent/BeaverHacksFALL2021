using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProfitTracker : MonoBehaviour
{
    public static float totalProfit;
    public float kwhCost = 11.02f;

    Text text;
    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<Text>();

        totalProfit = 0.00f;
    }

    // Update is called once per frame
    void Update()
    {
        totalProfit = kwhCost * EnergyManager.energyTotal;

        if (totalProfit < 100000)
        {
            text.text = "Profit: $" +  Mathf.Round(totalProfit * 100.0f) * 0.01f + "/hr";
        }
        else
        {
            text.text = "Profit: $ 0";
        }
    }
}
