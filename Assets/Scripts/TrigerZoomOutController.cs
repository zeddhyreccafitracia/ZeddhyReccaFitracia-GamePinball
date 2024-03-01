using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrigerZoomOutController : MonoBehaviour
{
    public Collider bola;
    public CameraController cameraController;
    private void OnTriggerEnter(Collider other)
    {
        if(other == bola)
        {
            Debug.Log("Bola kena");
            cameraController.GoBackToDefault();
        }
    }
}
