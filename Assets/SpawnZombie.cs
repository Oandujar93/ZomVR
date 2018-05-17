using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnZombie : MonoBehaviour {

    public Transform SpawnPoint;
    public GameObject Prefab;
    float timer;
    public float timeBetweenSpawn = 0.9f;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        // Add the time since Update was last called to the timer.
        timer += Time.deltaTime;

        if (timer > 3)
        {
            timer = 0;
            spawnZombie();
        }
    }

    void spawnZombie()
    { 
      Instantiate(Prefab, SpawnPoint.position, SpawnPoint.rotation);  
    }

}
