using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    
    private Scene currentScene;
    private Rigidbody2D rb;
    private Animator playerAnimation;
    private bool grounded;
    private float movement = 0.0f;


    public Transform groundCheck;
    public LayerMask whatIsGround;
    public float groundCheckRadius;
    public float moveSpeed;
    public float jumpHeight;
    

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();   //  Reference to the rigidbody2d component
        playerAnimation = GetComponent<Animator>(); //  Reference to the animator component
    }

    private void FixedUpdate()
    {
        //  Set grounded equal to whether this is true or not
        grounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatIsGround);

        Move();
        ReloadScene();
        PlayerAnimator();
    }

    public void Move()
    {
        movement = Input.GetAxis("Horizontal");

        if (Input.GetKeyDown(KeyCode.Space) && grounded) //  Check if space bar is pressed
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpHeight);
        }

        if (movement > 0.0f)
        {
            rb.velocity = new Vector2(moveSpeed, rb.velocity.y);
            transform.localScale = new Vector2(1f, 1f); //  If moving right set local scale to 1 (its default)
        }
        
        else if (movement < 0.0f)
        {
            rb.velocity = new Vector2(-moveSpeed, rb.velocity.y);
            transform.localScale = new Vector2(-1f, 1f);    //  If moving left change the scale on the x axis to it's opposite thus flipping the sprite
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

    public void PlayerAnimator()
    {
        playerAnimation.SetFloat("Speed", Mathf.Abs(rb.velocity.x));    //  Keep speed value positive so the player walk animation keeps playing whe walking left
        playerAnimation.SetBool("OnGround", grounded);
    }
}
