using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : MonoBehaviour {

    public GameObject cannonball;
    public float shootTimer;
    float timer;
    public float speed;
    public Transform SpawnLocation;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        timer -= Time.deltaTime;
        if (timer < 0)
        {
            timer = shootTimer;
            Spawn();
        }
	}

    void Spawn()
    {
        GameObject spawnCannonball = Instantiate(cannonball);
        StartCoroutine(DestroyAfterSeconds(spawnCannonball, 2f));
        spawnCannonball.transform.position = SpawnLocation.position;
        spawnCannonball.GetComponent<Rigidbody>().AddForce(transform.forward * speed, ForceMode.Impulse);
    }

    IEnumerator DestroyAfterSeconds(GameObject obj, float timeToWait)
    {
        yield return new WaitForSeconds(timeToWait);
        Destroy(obj);
    }
}
