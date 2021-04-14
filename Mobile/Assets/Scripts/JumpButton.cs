using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpButton : MonoBehaviour
{
    public Rigidbody2D rb;
    private float jumpSpeed;
    // Start is called before the first frame update

    // Update is called once per frame
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
  public void Jump()
    {
        rb.velocity = Vector2.up * jumpSpeed;
    }
}
