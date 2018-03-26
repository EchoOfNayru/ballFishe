using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Respawner : MonoBehaviour {

    //public GameObject Target;
    //public float offset;
    public string SceneToLoad;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Vector3 offsetVector = new Vector3(-250, Target.transform.position.y - offset, -250);
        //this.transform.position = offsetVector;
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            SceneManager.LoadScene(SceneToLoad);
        }
    }
}
