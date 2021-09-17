using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class build_SolarArray : MonoBehaviour
{
    public GameObject bluePrint;
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
        Instantiate(bluePrint,parent);
    }
}
