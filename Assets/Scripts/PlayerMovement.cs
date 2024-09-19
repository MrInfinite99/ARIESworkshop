using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Animator animator;  // making animator object
    public float moveSpeed = 5f; // Speed of movement
    public float jumpForce = 7f; // Force of jump
    private bool isGrounded = true; // To check if the player is on the ground
    private bool isFacingRight = true; // To track the last movement direction

    public bool isAlive = true;

    private Rigidbody2D rb; // Reference to Rigidbody2D component

    void Start()
    {
        // Get the Rigidbody2D component attached to the player
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        


        if (rb.position.y < -15.0f)
        {
            isAlive = false;
        }
        

        // Move left and right using arrow keys
        float moveInput = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(moveInput * moveSpeed, rb.velocity.y);

        animator.SetFloat("vel",moveInput );  // setting the vel parameter in animator

        // Check the player's movement direction and update the isFacingRight flag
        if (moveInput > 0)
        {
            isFacingRight = true;
        }
        else if (moveInput < 0)
        {
            isFacingRight = false;
        }

        // Set the direction parameter in the animator
        animator.SetBool("direction", isFacingRight);

        // Jump when the spacebar is pressed and the player is on the ground
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            animator.SetBool("jumping", true); // setting jumping parameter
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
            isGrounded = false; // Player is not on the ground while jumping
        }
    }

    // Check if player touches the ground
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true; // Player is back on the ground
            animator.SetBool("jumping", false);
            animator.SetBool("direction", isFacingRight);
        }
    }
}
