using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CapacityTracker : MonoBehaviour
{
    public static float capacityTotal;
    public float capacityPrint;

    Text text;
    // Start is called before the first frame update
    void Awake()
    {
        text = GetComponent<Text>();

        capacityTotal = 0;
    }

    // Update is called once per frame
    void Update()
    {
        capacityPrint = EnergyManager.energyTotal / capacityTotal;

        if(capacityPrint > 0)
        {
            text.text = "Capacity: " + Mathf.Round(capacityPrint * 100.0f) * 0.01f + "%";
        }
        else
        {
            text.text = "Capacity: 0%";
        }
        
    }
}
