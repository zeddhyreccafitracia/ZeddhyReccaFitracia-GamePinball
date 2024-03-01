using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    // public Transform dummyTarget;
    // public float dummyLength;
    public float returnTime;
    public float followSpeed;
    public float length;
    public Transform target;
    private Vector3 defaultPosition;
    public bool hasTarget {get {return target != null; }}

    // Start is called before the first frame update
    private void Start()
    {
        defaultPosition = transform.position;
        target = null;
        
    }

    // Update is called once per frame
    private void Update()
    {
        if(hasTarget)
        {
            Vector3 targetToCameraDirection = transform.rotation * -Vector3.forward;
            Vector3 targetPosition = target.position + (targetToCameraDirection * length);

            transform.position = Vector3.Lerp(transform.position, targetPosition, followSpeed * Time.deltaTime);
        }
        // if(Input.GetKey(KeyCode.Space))
        // {
        //     FocusAtTarget(dummyTarget, dummyLength);
        // }
        // if(Input.GetKey(KeyCode.R))
        // {
        //     GoBackToDefault();
        // }
    }
    
    public void FollowTarget(Transform targetTransform, float targetLength)
    {
        StopAllCoroutines();
        target = targetTransform;
        length = targetLength;
    }

    // public void FocusAtTarget(Transform targetTransform, float length)
    // {
    //     target = targetTransform;

    //     //kalkulasi posisi untuk fokus ke target
    //     Vector3 targetToCameraDirection = transform.rotation * -Vector3.forward;
    //     Vector3 targetPosition = targetTransform.position + (targetToCameraDirection * length);

    //     //gerakan ke posisi tersebut
    //     StartCoroutine(MovePosition(targetPosition, 5));
    // }

    public void GoBackToDefault()
    {
        target = null;

        //gerakan ke posisi default dalam waktu return time
        StopAllCoroutines();
        StartCoroutine(MovePosition(defaultPosition, returnTime));
    }

    private IEnumerator MovePosition(Vector3 target, float time)
    {
        float timer = 0;
        Vector3 start = transform.position;

        while(timer < time)
        {
            //pindahkan posisi camera secara bertahap
            transform.position = Vector3.Lerp(start, target, Mathf.SmoothStep(0.0f, 1.0f, timer/time));

            timer += Time.deltaTime;
            yield return new WaitForEndOfFrame();
        }

        transform.position = target;
    }
}
