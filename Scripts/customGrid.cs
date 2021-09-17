using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class customGrid : MonoBehaviour
{
    public GameObject target;
    
    Vector3 truePos;
    public float gridSize;

    void LateUpdate()
    {
        if (target)
        {
            truePos.x = Mathf.Floor(target.transform.position.x / gridSize) * gridSize;
            truePos.y = 0.5f;
            truePos.z = Mathf.Floor(target.transform.position.z / gridSize) * gridSize;

            target.transform.position = truePos;
        }
    }
}
