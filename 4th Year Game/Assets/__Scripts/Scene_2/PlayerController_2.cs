using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
/*
 * Seperate controller scripit for the player when on scene two as we must allow for moving on both axis. 'Animation
 * is achieved by simply flipping the players scale to the opposite of what is is, depending on where hes
 * facing and where hes going.
 */
public class PlayerController_2 : MonoBehaviour
{

    private Rigidbody2D rb;
    private Scene currentScene;

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
        ReloadScene();
    }

    public void Move()
    {
        //  Assign input to vector 2 x and y
        movement.x = Input.GetAxis("Horizontal");
        movement.y = Input.GetAxis("Vertical");

        //  Actually move the player
        rb.MovePosition(rb.position + movement * moveSpeed * Time.deltaTime);

        if(movement.x < 0.0f)   //  Left
        {
            transform.rotation = Quaternion.Euler(Vector3.back * -90);
            transform.localScale = new Vector2(1f, -1f);
        }
        else if(movement.x > 0.0f)  //  Right
        {
            transform.rotation = Quaternion.Euler(Vector3.forward * -90);
            transform.localScale = new Vector2(1f, -1f);

        }

        if (movement.y < 0.0f)  //  Down
        {
            transform.eulerAngles = Vector3.up * 0;
            transform.localScale = new Vector2(1f, 1f);
        }
        else if (movement.y > 0.0f) //  Up
        {
            transform.eulerAngles = Vector3.down * 0;
            transform.localScale = new Vector2(1f, -1f);
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
