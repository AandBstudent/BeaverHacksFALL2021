using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class build_SolarArray : MonoBehaviour
{
    public GameObject bpSolarArray;
    public GameObject bpBattery;
    public GameObject bpWindTurbine;
    public GameObject bpNuclearPowerPlant;
    public GameObject bpGeothermalPlant;
    public Earth earth;
    public Transform parent;
    float destruction;

   /* void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            Instantiate(bluePrint, parent);
        }
    }*/

    public void spawn_BP()
    {
        MousePosition3D.buildPlaced += 0.05f;
        destruction = 1;
        earth.currentHealth -= destruction;
        earth.healthBar.SetHealth(earth.currentHealth);
        Instantiate(bpSolarArray, parent);
    }

    public void spawn_BP_batteryP()
    {
        destruction = 5;
        earth.currentHealth -= destruction;
        earth.healthBar.SetHealth(earth.currentHealth);
        Instantiate(bpBattery, parent);
    }

    public void spawn_BP_windTurbine()
    {
        MousePosition3D.buildPlaced += 0.1f;
        destruction = 2;
        earth.currentHealth -= destruction;
        earth.healthBar.SetHealth(earth.currentHealth);
        Instantiate(bpWindTurbine, parent);
    }

    public void spawn_BP_powerPlant()
    {
        MousePosition3D.buildPlaced += 3.5f;
        destruction = 10;
        earth.currentHealth -= destruction;
        earth.healthBar.SetHealth(earth.currentHealth);
        Instantiate(bpNuclearPowerPlant, parent);
    }

    public void spawn_BP_geothermalPlant()
    {
        MousePosition3D.buildPlaced += 3.5f;
        destruction = 2;
        earth.currentHealth -= destruction;
        earth.healthBar.SetHealth(earth.currentHealth);
        Instantiate(bpGeothermalPlant, parent);
    }

}
