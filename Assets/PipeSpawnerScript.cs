using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawnerScript : MonoBehaviour
{
    // Create a pipe variable to reference the prefabricated pipe object that we will
    // spawn continuosly on the map.
    // Remember that the pipe prefabricated object already implements movement,
    // we now just need to spawn the pipes
    public GameObject pipe;
    private float spawnRate = 3;
    private float timer = 0;
    public float heightOffset = 10; // Height offset of Top Pipe and Bottom Pipe

    // Start is called before the first frame update
    void Start()
    {
        spawnPipe(); // ...Spawn a Pipe object on screen
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate) // If timer is less than where the Pipe object should spawn...
        {
            timer += Time.deltaTime; // ...update timer.
        }
        else // Otherwise...
        {
            spawnPipe(); // ...Spawn a Pipe object on screen
            timer = 0; // and restart the timer.
        }
        
    }

    void spawnPipe() 
    {
        float lowestPoint = transform.position.y - heightOffset; // Lowest potential y-point of spawner
        float highestPoint = transform.position.y + heightOffset; // Highest potential y-point of spawner

        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0), transform.rotation);
    }
}
