using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MovementScript : MonoBehaviour
{
    public float speed = 5f;          // Horizontal movement speed
    public float jumpForce = 10f;    // Jumping force
    private Rigidbody2D rb;
    private bool isTouchingFloor;    // Whether the player is touching the floor

    void Start()
    {
        // Get the Rigidbody2D component
        rb = GetComponent<Rigidbody2D>();
    }

    public void SetXVelocity(float direction)
    {
        // Set the x velocity while maintaining the y velocity
        rb.velocity = new Vector2(direction * speed, rb.velocity.y);
    }

    public void Jump()
    {
        // Only jump if the player is touching the floor
        if (isTouchingFloor)
        {
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        // Check if the player is touching the floor (by tag)
        if (collision.collider.CompareTag("Floor"))
        {
            isTouchingFloor = true;
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        // Check if the player has left the floor
        if (collision.collider.CompareTag("Floor"))
        {
            isTouchingFloor = false;
        }
    }
}
