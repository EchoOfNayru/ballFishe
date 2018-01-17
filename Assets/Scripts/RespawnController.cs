using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnController : MonoBehaviour {

    public GameObject [] Collectibles;
    public GameObject [] ScoreGates;
    public Vector3 [] ScoreGateLocations;
    public Vector3 Spawnlocation;

    // Use this for initialization
    void Start () {
        Spawnlocation = new Vector3(0, 9, 1);
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            
            other.transform.position = Spawnlocation;
            BallController ballController = other.GetComponent<BallController>();
            ballController.rb.velocity = Vector3.zero;
            BallController.score = 0;
            int i = 0;
            foreach (GameObject collectible in Collectibles)
            {
                collectible.SetActive(true);
            }
            foreach (GameObject gate in ScoreGates)
            {
                gate.transform.position = ScoreGateLocations[i];
                i++;
            }
        }
    }
}
