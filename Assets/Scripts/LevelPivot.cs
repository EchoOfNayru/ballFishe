using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



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

    public bool isOn;
    public float startDelayTime;
    //public string LoadLevel;

    // Use this for initialization
    void Start ()
    {
        isOn = false;
        StartCoroutine(StartDelay(startDelayTime));
        startForward = transform.forward;
        startRight = transform.right;
	}
	
	// Update is called once per frame
	void FixedUpdate ()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
        if (!isOn)
        {
            horizontal = 0;
            vertical = 0;
        }

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


        Vector3 desiredRot = transform.rotation.eulerAngles;
        desiredRot.x = Mathf.Clamp(ClampAngle(desiredRot.x), -30, 30);

        //if (this.transform.rotation.x >= 30)
        //{
        //    this.transform.eulerAngles = new Vector3(30f, this.transform.rotation.y, this.transform.rotation.z);
        //}
        //if (this.transform.rotation.x <= -30)
        //{
        //    this.transform.eulerAngles = new Vector3(-30f, this.transform.rotation.y, this.transform.rotation.z);
        //}
        //if (this.transform.rotation.z >= 30)
        //{
        //    this.transform.eulerAngles = new Vector3(this.transform.rotation.x, this.transform.rotation.y, 30f);
        //}
        //if (this.transform.rotation.z <= -30)
        //{
        //    this.transform.eulerAngles = new Vector3(this.transform.rotation.x, this.transform.rotation.y, -30f);
        //}

    }

    private IEnumerator StartDelay(float waitTime)
    {
        
        yield return new WaitForSeconds(waitTime);
        isOn = true;
    }

    float ClampAngle( float angle)
    {
        if (angle < 0f)
            return angle + (360f * (int)((angle / 360f) + 1));
        else if (angle > 360f)
            return angle - (360f * (int)(angle / 360f));
        else
            return angle;
    }
}

