using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TerrainDistance : MonoBehaviour {

    public GameObject Target;
    public float offset;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 offsetVector = new Vector3(0, Target.transform.position.y - offset, 0);
        this.transform.position = offsetVector;
	}

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.tag == "Player")
        {
            SceneManager.LoadScene("Scen");
        }
    }
}
