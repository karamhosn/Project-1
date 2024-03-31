using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeScript : MonoBehaviour
{
    public float moveSpeed = 5; // Speed of Pipe (parent to top and bottom)
    public float deadZone = -28; // deadZone is the x-coordinate where the Pipe will leave the camera
                                 // Best practice to delete objects out of frame in this kind
                                 // of game.


    // No need for Start()

    // Update is called once per frame
    void Update()
    {
        // Changes the position of Pipe per frame
        // The speed of change is determined by variable moveSpeed
        // Multipying by Time.deltaTime allows for game to run at same speed
        // no matter the frame rate (look into Sources and Resources description for more)
        transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime;

        if (transform.position.x < deadZone) // If Pipe object reaches the deadZone
        {
            Debug.Log("Pipe Deleted");
            Destroy(gameObject); // ...destroy Pipe object
        }
    }
}
