using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerZoomInController : MonoBehaviour
{
    public Collider bola;
    public CameraController cameraController;
    public float length;
    private void OnTriggerEnter(Collider other)
    {
        if(other == bola)
        {
            Debug.Log("Bola kena");
            cameraController.FollowTarget(bola.transform, length);

        }
    }
}
