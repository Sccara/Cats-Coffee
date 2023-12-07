using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MousePosition2D : MonoBehaviour
{
    public Vector3 GetMousePosition2D(Camera mainCamera)
    {
        Vector3 mouseWorldPosition = mainCamera.ScreenToWorldPoint(Input.mousePosition);
        mouseWorldPosition.z = 0f;

        return mouseWorldPosition;
    }
}