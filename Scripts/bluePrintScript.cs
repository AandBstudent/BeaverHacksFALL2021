using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bluePrintScript : MonoBehaviour
{

    public GameObject prefab;
    public GameObject textPrefab;
    public int buildCost;
    public int watt;
    public float capacity;

    Vector3 placement;
    float gridSize = 1;
    

    // Update is called once per frame
    void Update()
    {
        string prefabName = prefab.name;
        if (Input.GetMouseButton(0))
        {
            if (prefabName == "RR_solar_array")
            {
                placement.y = 0.5f;
            }
            else if (prefabName == "RR_battery")
            {
                placement.y = 0.25f;
            }
            else if (prefabName == "RR_windTurbine")
            {
                placement.y = 1.5f;
            }
            else if (prefabName == "RR_NuclearPlant")
            {
                placement.y = 1.0f;
            }

            placement.x = Mathf.Floor(transform.position.x / gridSize) * gridSize;
            
            placement.z = Mathf.Floor(transform.position.z / gridSize) * gridSize;
            
            if(textPrefab)
            {
                ShowFloatingText();
            }
            Instantiate(prefab, placement, transform.rotation);
            MoneyManager.score -= buildCost;
            WattManager.wattTotal += watt;
            EnergyManager.energyTotal += (float) watt / 1000;
            CapacityTracker.capacityTotal += capacity;
            Destroy(gameObject);
        }


        //Debug.Log(transform.position.y);
    }

    void ShowFloatingText()
    {
        var floatText = Instantiate(textPrefab, transform.position, Quaternion.identity);
        floatText.GetComponent<TextMesh>().text = "$ " + buildCost.ToString();
    }
}
