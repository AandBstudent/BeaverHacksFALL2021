using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MousePosition3D : MonoBehaviour
{
    [SerializeField] private Camera mainCamera;

    public static float buildPlaced;

    private void Update()
    {
        Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out RaycastHit raycastHit))
        {
            transform.position = raycastHit.point;
        }

        if(CapacityTracker.capacityTotal > 0 )
        {
            EnergyManager.energyTotal += buildPlaced * Time.deltaTime;
        }

        // Houses use energy
    }

}
