using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HouseManager : MonoBehaviour
{
    public static int house;

    public EnergyBar energyBar;

    int max = 2000;
    int min = 1000;

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
        else if (EnergyManager.energyTotal >= min && EnergyManager.energyTotal <= max)
        {
            house += 1;
            energyBar.SetMaxEnergy(max);
            energyBar.SetMinEnergy(min);
            min += 1000;
            max += 1000;
        }
        /*
        else if (EnergyManager.energyTotal >= 1000 && EnergyManager.energyTotal <= 2000)
        {
            house = 1;
            energyBar.SetMaxEnergy(2000);
            energyBar.SetMinEnergy(1000);
        }
        else if (EnergyManager.energyTotal >= 2000 && EnergyManager.energyTotal <= 3000)
        {
            house = 2;
            energyBar.SetMaxEnergy(3000);
            energyBar.SetMinEnergy(2000);
        }
        else
        {
            house = 3;
            energyBar.SetMaxEnergy(4000);
            energyBar.SetMinEnergy(3000);
        }*/

        text.text = "Houses Powered: " + house;
    }
}
