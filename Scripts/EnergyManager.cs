using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnergyManager : MonoBehaviour
{
    public static float energyTotal;

    Text text;
    
    void Awake()
    {
        text = GetComponent<Text>();

        energyTotal = 0;
    }

    // Update is called once per frame
    void Update()
    {
        text.text = "Energy: " + Mathf.Round(energyTotal *100.0f)*0.01f + " kWh";
    }
}
