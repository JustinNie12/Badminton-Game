using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public Transform player;
    public Rigidbody2D rb;
    public float speed;
    private float yAxis;
    private float move;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        yAxis = player.transform.position.y;
    }
    void FixedUpdate()
    {
            rb.velocity = new Vector2( move * speed, yAxis);

    }
    public void onPressLeft()
    {
        move = -1;
    }
    public void onRelease()
    {
        move = 0;
    }
    public void onPressRight()
    {
        move = 1;
    }
}
