using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class build_SolarArray : MonoBehaviour
{
    public GameObject bpSolarArray;
    public GameObject bpBattery;
    public GameObject bpWindTurbine;
    public Transform parent;

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
        Instantiate(bpSolarArray, parent);
    }

    public void spawn_BP_batteryP()
    {
        Instantiate(bpBattery, parent);
    }

    public void spawn_BP_windTurbine()
    {
        MousePosition3D.buildPlaced += 0.1f;
        Instantiate(bpWindTurbine, parent);
    }

}
