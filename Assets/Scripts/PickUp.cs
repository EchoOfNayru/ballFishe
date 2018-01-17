using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour {

    public GameObject collectible;

	// Use this for initialization
	void Start () {
		collectible.SetActive(true);
	}
	
	// Update is called once per frame
	void Update () {
        collectible.transform.Rotate(new Vector3(1f, 1f, 1f));
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            BallController.score += 1;
            collectible.SetActive(false);
        }
    }

    //OnTriggerEnter(Collider other)

    //if the colliders tag is the player
    //Get the BallController componenet and add score

}
