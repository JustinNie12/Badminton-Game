﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Birdie : MonoBehaviour
{
    private Rigidbody2D rb;
    private float force = 100;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    // Start is called before the first frame update
    void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log(col.gameObject.tag);
        if(col.gameObject.tag == "Racket")
        {
            rb.velocity = Vector2.zero;
            rb.AddForce(new Vector2(force*7,force*7));
            Debug.Log("Collision went off!");
        }
        if(col.gameObject.tag == "Wall")
        {
            rb.velocity = Vector2.zero;
            rb.AddForce(new Vector2(force * -7, force * 7));
        }
    }
}
