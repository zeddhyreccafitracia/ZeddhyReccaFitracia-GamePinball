using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerRampController : MonoBehaviour
{
    public float score;
    public ScoreManager scoreManager;
    public Collider bola;
    private void OnTriggerEnter(Collider other)
    {
        if(other == bola)
        {
            Debug.Log("Bola kena");
            //score add
            scoreManager.AddScore(score);
        }
    }
}
