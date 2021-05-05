using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    private Rigidbody2D rb;

    private float speed = 3f;
    private float jumpSpeed = 6f;

    private bool moveLeft;
    private bool isMoving;
    private bool isGrounded;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        isMoving = false;
    }

    void Update()
    {
        HandleMoving();
    }
    void HandleMoving()
    {
        if (!isMoving)
        {
            StopMoving();
        }
        else
        {
            if (moveLeft)
            {
                MoveLeft();
            }
            else if (!moveLeft)
            {
                MoveRight();
            }
        }
    }
    public void AllowMovement(bool movement)
    {
        isMoving = true;
        moveLeft = movement;
    }
    public void DontAllowMovement()
    {
        isMoving = false;
    }
    public void Jump()
    {
        if (isGrounded)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpSpeed);
        }
    }
    public void MoveLeft()
    {
        rb.velocity = new Vector2(-speed, rb.velocity.y);
    }
    public void MoveRight()
    {
        rb.velocity = new Vector2(speed, rb.velocity.y);
    }
    public void StopMoving()
    {
        rb.velocity = new Vector2(0f, rb.velocity.y);
    }

    void DetectInput()
    {
        float x = Input.GetAxisRaw("Horizontal");

        if (x > 0)
        {
            MoveRight();
        }
        else if (x < 0)
        {
            MoveLeft();
        }
        else
        {
            StopMoving();
        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Ground")
        {
            isGrounded = true;
        }
    }
    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            isGrounded = false;
        }
    }
}
