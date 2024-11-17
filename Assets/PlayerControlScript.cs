using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerControlScript : MonoBehaviour
{
    public MovementScript movementScript; // Reference to the MovementScript
    void Start()
    {
        movementScript = GetComponent<MovementScript>();
    }
    void Update()
    {
        // Check for horizontal movement input
        if (Input.GetKey(KeyCode.A))
        {
            movementScript.SetXVelocity(-1f); // Move left
        }
        else if (Input.GetKey(KeyCode.D))
        {
            movementScript.SetXVelocity(1f); // Move right
        }
        else
        {
            movementScript.SetXVelocity(0f); // Stop horizontal movement
        }

        // Check for jump input
        if (Input.GetKey(KeyCode.W))
        {
            movementScript.Jump(); // Trigger jump
        }
    }
}
