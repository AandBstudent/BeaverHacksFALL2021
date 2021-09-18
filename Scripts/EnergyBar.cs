using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnergyBar : MonoBehaviour
{
    public Slider slider;
    
    public void SetMaxEnergy(float energy)
    {
        slider.maxValue = energy;
        slider.value = 0;
    }

    public void SetMinEnergy(float energy)
    {
        slider.minValue = energy;
    }

    public void SetEnergy(float energy)
    {
        slider.value = energy;
    }
}
