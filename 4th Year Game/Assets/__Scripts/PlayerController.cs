using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rb;

    public float moveSpeed;
    public float jumpHeight;
    

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();   //  Reference to the rigidbody2d component
    }

    private void FixedUpdate()
    {

    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)) //  Check if space bar is pressed
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpHeight);
        }

        if (Input.GetKey(KeyCode.D)) //  Check if space bar is pressed
        {
            rb.velocity = new Vector2(moveSpeed, rb.velocity.y);
        }
        if (Input.GetKey(KeyCode.A)) //  Check if space bar is pressed
        {
            rb.velocity = new Vector2(-moveSpeed, rb.velocity.y);
        }
    }
}
