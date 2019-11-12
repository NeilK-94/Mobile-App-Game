using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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

        movement.x = Input.GetAxis("Horizontal");
        movement.y = Input.GetAxis("Vertical");

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
