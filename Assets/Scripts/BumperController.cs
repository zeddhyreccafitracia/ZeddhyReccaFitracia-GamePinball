using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BumperController : MonoBehaviour
{
    public Collider bola;
    public float multiplier;
    public Color color;
    public float score;
    public AudioManager audioManager;
    public VFXManager vFXManager;
    public ScoreManager scoreManager;

    private Renderer renderer;
    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<Renderer>();
        animator = GetComponent<Animator>();

        renderer.material.color = color;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider == bola)
        {
            Debug.Log("Kena Bola");
            Rigidbody bolaRig = bola.GetComponent<Rigidbody>();
            bolaRig.velocity *= multiplier;

            //animasiin
            animator.SetTrigger("hit");

            //playsfx
            audioManager.PlaySFXBumper(collision.transform.position);

            //playvfx
            vFXManager.PlayVFXBumper(collision.transform.position);
            
            //score add
            scoreManager.AddScore(score);
        }
    }
}
