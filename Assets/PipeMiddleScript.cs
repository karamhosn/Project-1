using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PipeMiddleScript : MonoBehaviour
{
    
    // We must establish a reference to "LogicScript" first
    public LogicScript logic;

    void Start()
    {
        // Establishes a line of communication between "PipeMiddleScript" and "LogicScript"
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
        
        // NOTE: Code will look for the first GameObject in the hierarchy with the
        // "Logic" tag. Since only one GameObject has this tag, this is fine
    }

    // No need for Update()

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // After creating the Layer "Bird" under the 3rd row in Unity
        // we check that the collision that occured was with the Bird (layer == 3)
        // before adding score.

        // In other words, we are checking it is the Bird object that collided
        // before adding to score.
        if (collision.gameObject.layer == 3) // FUTURE PROOFING
        {
            logic.addScore(1); // Runs addScore function in LogicScript
        }
    }
}
