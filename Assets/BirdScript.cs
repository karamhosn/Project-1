using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    // BirdScript cannot talk to the other compenents of the Bird object by default
    // We must make a line of communication by storing a reference to that specific component
    // We create a reference in BirdScript and fill it in Unity by dragging and dropping

    // public variables allow us to change the variable in Unity insepctor
    public Rigidbody2D myRigidbody; // Create reference to Rigidbody 2D
                                    // A line of communication between BirdScript and Bird object's Rigidbody 2D
    public float flapStrength; // By adding flapStrength as a variable in BirdScript, we can change it easily in
                               // the Unity editor, rather than in BirdScript itself
    public LogicScript logic; // Establish a reference to "LogicScript"
    public bool birdIsAlive = true;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame 
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && birdIsAlive) // If the space bar has been pressed
        {
            // Gives us access to the velocity of Bird object
            // Vector2.up is a shorthand to move the Bird object up (0, 1) or straight up one unit
            myRigidbody.velocity = Vector2.up * flapStrength;
        }

        if (transform.position.y > 16.2 || transform.position.y < -16.2)
        {
            logic.gameOver();
            birdIsAlive = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision) 
    {
        logic.gameOver();
        birdIsAlive = false;
    }
}
