using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Device : MonoBehaviour, I_Interactable
{
    [SerializeField] private string deviceName;

    private void OnMouseUp()
    {
        Interact();
    }

    public virtual void Interact()
    {
        Debug.Log($"DeviceName: {deviceName}");
    }
}
