using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController_2 : MonoBehaviour
{

    private Rigidbody2D rb;

    private float movementHorizontal = 0.0f;
    private float movementVertical= 0.0f;

    Vector2 movement;

    public float moveSpeed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();   //  Reference to the rigidbody2d component
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Move();
    }

    public void Move()
    {

        movement.x = Input.GetAxis("Horizontal");
        movement.y = Input.GetAxis("Vertical");

        rb.MovePosition(rb.position + movement * moveSpeed * Time.deltaTime);

        if(movement.x < 0.0f)
        {
            transform.rotation = Quaternion.Euler(Vector3.forward * -90);
        }
        else if(movement.x > 0.0f)
        {
            transform.eulerAngles = Vector3.forward * 90;
        }

        if (movement.y < 0.0f)
        {
            transform.eulerAngles = Vector3.forward * 0;
            transform.localScale = new Vector2(1f, 1f);
        }
        else if (movement.y > 0.0f)
        {
            transform.eulerAngles = Vector3.forward * 0;
            transform.localScale = new Vector2(1f, -1f);
        }

        //movementHorizontal = Input.GetAxis("Horizontal");
        //movementVertical = Input.GetAxis("Vertical");

        //if (movementHorizontal > 0.0f)
        //{
        //    rb.velocity = new Vector2(moveSpeed, rb.velocity.y);
        //    transform.eulerAngles = Vector3.forward * 90;  //  If moving right set local rotation to 90
        //}

        //else if (movementHorizontal < 0.0f)
        //{
        //    rb.velocity = new Vector2(-moveSpeed, rb.velocity.y);
        //    transform.rotation = Quaternion.Euler(Vector3.forward * -90);    //  If moving left change the rotation to -90
        //}
        //else
        //{
        //    rb.velocity = new Vector2(0f, rb.velocity.y);   //  Sets player horizontal movement to 0, this prevents sliding

        //}

        //if (movementVertical > 0.0f)
        //{
        //    transform.eulerAngles = Vector3.forward * 0;
        //    rb.velocity = new Vector2(rb.velocity.x, moveSpeed);
        //    transform.localScale = new Vector2(1f, -1f); //  If moving up set local scale to -1 on the Y thus flipping
        //}

        //else if (movementVertical < 0.0f)
        //{
        //    transform.eulerAngles = Vector3.forward * 0;
        //    rb.velocity = new Vector2(rb.velocity.x, -moveSpeed);
        //    transform.localScale = new Vector2(1f, 1f);    //  If moving down change the scale on the y axis to 1
        //}
        //else
        //{
        //    rb.velocity = new Vector2(rb.velocity.x, 0f);   //  Sets player vertical movement to 0, this prevents sliding

        //}


    }
}
