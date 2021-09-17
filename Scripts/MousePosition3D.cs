using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MousePosition3D : MonoBehaviour
{
    [SerializeField] private Camera mainCamera;

    private void Update()
    {
        Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out RaycastHit raycastHit))
        {
            transform.position = raycastHit.point;
        }

        if(CapacityTracker.capacityTotal > 0 )
        {
            EnergyManager.energyTotal += 0.01f * Time.deltaTime;
        }

        // Houses use energy
    }

}
