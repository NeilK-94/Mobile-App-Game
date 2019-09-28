using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    
    private Scene currentScene;
    private Rigidbody2D rb;
    private bool grounded;

    public Transform groundCheck;
    public LayerMask whatIsGround;

    public float groundCheckRadius;
    public float moveSpeed;
    public float jumpHeight;
    

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();   //  Reference to the rigidbody2d component
    }

    private void FixedUpdate()
    {
        //  Set grounded equal to whether this is true or not
        grounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatIsGround);
    }

    void Update()
    {
        Move();
        ReloadScene();
    }

    public void Move()
    {
        if (Input.GetKeyDown(KeyCode.Space) && grounded) //  Check if space bar is pressed
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

    public void ReloadScene()
    {
        currentScene = SceneManager.GetActiveScene();   //  Sets current scene equal to the active scene

        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(currentScene.name);  //  loads currentScene
            Debug.Log(currentScene.name);
        }

    }
}
