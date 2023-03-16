using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{  

        public GameObject[] balloonPrefabs; //array to store balloon obj
        public float startDelay = 0.5f;
        public float spawnInterval = 1.5f;
        
// Start is called before the first frame update
    void Start()
    {
      InvokeRepeating("SpawnRandomBalloon", startDelay, spawnInterval);
    }
    void SpawnRandomBalloon()//this is a function for managing balloon spawns 
    {
        // Get a random position on the x-axis
        Vector3 spawnPos = new Vector3(Random.Range(-7,7),0,0);

        //Pick a random balloon from the ballon array
        int balloonIndex = Random.Range(0,balloonPrefabs.Length);

        //spawn random balloon at spawn position
        Instantiate(balloonPrefabs[balloonIndex], spawnPos, balloonPrefabs[balloonIndex].transform.rotation);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
