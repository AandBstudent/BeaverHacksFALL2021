using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bluePrintScript : MonoBehaviour
{

    public GameObject prefab;

    Vector3 placement;
    float gridSize = 1;

    // Update is called once per frame
    void Update()
    {

        if(Input.GetMouseButton(0))
        {
            placement.x = Mathf.Floor(transform.position.x / gridSize) * gridSize;
            placement.y = 0.5f;
            placement.z = Mathf.Floor(transform.position.z / gridSize) * gridSize;

            
            Instantiate(prefab, placement, transform.rotation);
            Destroy(gameObject);
        }


        Debug.Log(transform.position.y);
    }
}
