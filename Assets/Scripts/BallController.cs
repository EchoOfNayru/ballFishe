using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour {

    public Rigidbody rb;
    public float downForce;
    public float startDelayTime;

    public bool isGravity;

    // Use this for initialization
    void Start() {
       isGravity = false;
       StartCoroutine(StartDelay(startDelayTime));
    }

    private void FixedUpdate() {
       if (isGravity)
        {
            rb.AddForce(-Vector3.up * downForce);
        }
    }

    private IEnumerator StartDelay(float waitTime)
    {
        
        yield return new WaitForSeconds(waitTime);
        isGravity = true;
    }
}
