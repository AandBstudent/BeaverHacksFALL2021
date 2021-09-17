using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class build_SolarArray : MonoBehaviour
{
    public GameObject bpSolarArray;
    public GameObject bpBattery;
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
        Instantiate(bpSolarArray, parent);
    }

    public void spawn_BP_batteryP()
    {
        Instantiate(bpBattery, parent);
    }

}
