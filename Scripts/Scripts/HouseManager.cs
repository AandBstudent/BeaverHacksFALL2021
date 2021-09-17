using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HouseManager : MonoBehaviour
{
    public static int house;

    Text text;
    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<Text>();

        house = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(EnergyManager.energyTotal < 1000)
        {
            house = 0;
        }
        else if (EnergyManager.energyTotal >= 1000 && EnergyManager.energyTotal <= 2000)
        {
            house = 1;
        }
        else if (EnergyManager.energyTotal >= 2000 && EnergyManager.energyTotal <= 3000)
        {
            house = 2;
        }
        else
        {
            house = 3;
        }
        text.text = "Houses Powered: " + house;
    }
}
