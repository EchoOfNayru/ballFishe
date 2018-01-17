using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreGate : MonoBehaviour {

    public GameObject BigDoor;
    Vector3 moveTo;
    public float lerpTime;
    public int amountToUnlock;
    public float unlockHeight;

	// Use this for initialization
	void Start () {
        moveTo = transform.position + (Vector3.up * unlockHeight);
	}
	
	// Update is called once per frame
	void Update () {
        if (BallController.score == amountToUnlock)
        {
            transform.position = Vector3.Lerp(transform.position, moveTo, lerpTime * Time.deltaTime);
        }
	}
}
