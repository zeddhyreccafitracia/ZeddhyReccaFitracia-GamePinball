using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchController : MonoBehaviour
{
    private enum SwitchState
    {
        Off,
        On,
        Blink
    }
    public Collider bola;
    public Material offMaterial;
    public Material onMaterial;
    public float score;
    public ScoreManager scoreManager;
    public AudioManager audioManager;
    public VFXManager vFXManager;

    //private bool isOn;
    private SwitchState state;
    private Renderer renderer;
    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<Renderer>();

        Set(false);
        StartCoroutine(BlinkTimerStart(5));
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other == bola)
        {
            Debug.Log("Bola kena switch!");
            Toggle();

            //score add
            scoreManager.AddScore(score);

            //playsfx
            audioManager.PlaySFXSwitch(other.transform.position);

            //playvfx
            vFXManager.PlayVFXSwitch(other.transform.position);
        }
    }

    private void Set(bool active)
    {

        if(active == true)
        {
            state = SwitchState.On;
            renderer.material = onMaterial;
            StopAllCoroutines();
        }
        else
        {
            state = SwitchState.Off;
            renderer.material = offMaterial;
            StartCoroutine(BlinkTimerStart(5));
        }
    }

    private void Toggle()
    {
        if(state == SwitchState.On)
        {
            Set(false);
        }
        else{
            Set(true);
        }
    }

    private IEnumerator Blink(int times)
    {
        state = SwitchState.Blink;

        //int blinkTimes = times * 2;
        for (int i = 0; i < times; i++)
        {
            renderer.material = onMaterial;
            yield return new WaitForSeconds(0.5f);
            renderer.material = offMaterial;
            yield return new WaitForSeconds(0.5f);
        }
        state = SwitchState.Off;

        StartCoroutine(BlinkTimerStart(5));
    }

    private IEnumerator BlinkTimerStart(float time)
    {
        yield return new WaitForSeconds(time);
        StartCoroutine(Blink(2));
    }
}
