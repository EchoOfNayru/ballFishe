using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelPivot : MonoBehaviour {

    Vector3 startForward;
    Vector3 startRight;

    float horizontal;
    float vertical;

    public GameObject Camera;

    public float rotTime;

    public bool isRotatingForward;
    public bool isRotatingBackwards;
    public bool isRotatingLeft;
    public bool isRotatingRight;

    public GameObject test;

	// Use this for initialization
	void Start ()
    {
        startForward = transform.forward;
        startRight = transform.right;
	}
	
	// Update is called once per frame
	void FixedUpdate ()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");

        Debug.Log(vertical);

        if (vertical < -0.6)
        {
            isRotatingForward = true;
            isRotatingBackwards = false;
        }
        else if (vertical > 0.6)
        {
            isRotatingForward = false;
            isRotatingBackwards = true;
        }
        else
        {
            isRotatingForward = false;
            isRotatingBackwards = false;
        }

        if (horizontal < -0.6)
        {
            isRotatingLeft = true;
            isRotatingRight = false;
        }
        else if (horizontal > 0.6)
        {
            isRotatingLeft = false;
            isRotatingRight = true;
        }
        else
        {
            isRotatingLeft = false;
            isRotatingRight = false;
        }

        if (isRotatingForward)
        {
            transform.RotateAround(test.transform.position, Camera.transform.right * 10, 1);
        }
        if (isRotatingBackwards)
        {
            transform.RotateAround(test.transform.position, -Camera.transform.right * 10, 1);
        }
        if (!isRotatingForward && !isRotatingBackwards)
        {
           
        }


        if (isRotatingLeft)
        {
            transform.RotateAround(test.transform.position, Camera.transform.forward * 10, 1);
        }
        if (isRotatingRight)
        {
            transform.RotateAround(test.transform.position, -Camera.transform.forward * 10, 1);
        }
        if (!isRotatingLeft && !isRotatingRight)
        {

        }


	}
}

