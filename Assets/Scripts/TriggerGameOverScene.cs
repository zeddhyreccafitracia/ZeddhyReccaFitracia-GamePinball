using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerGameOverScene : MonoBehaviour
{
    public Collider bola;

    private void OnTriggerEnter(Collider other)
    {
        if(other == bola)
        {
            Debug.Log("game over screen kena");
            SceneManager.LoadScene("GameOver");

        }
    }
}
