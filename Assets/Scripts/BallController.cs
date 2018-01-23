using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour {

    public Rigidbody rb;
    public float downForce;

    // Use this for initialization
    void Start() {

    }

    private void FixedUpdate() {
        rb.AddForce(-Vector3.up * downForce);
    }
}
