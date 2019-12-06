using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerCheck : MonoBehaviour
{
    //public GameObject block1;
    public Collider2D trigCol;
    public GameObject platform;

    public Transform spawnPointYellow;
    public Transform spawnPointYellow1;
    public Transform spawnPointGreen;
    public Transform spawnPointRed;
    public Transform spawnpointBlue;

    public Renderer platRenderer;

    private Scene currentScene;
    private bool isPaused = false;

    private int counter = 0;
    public GameObject creditsUI;


    [SerializeField]
    private AudioSource wrongSound, correctSound;

    public void Update()
    {
        if(counter == 3)
        {
            //SceneManager.LoadScene("Menu");
            creditsUI.SetActive(true);
            Time.timeScale = 0f;    //  Pause time
            isPaused = true;

        }
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        //  Check what tag has entered what trigger
        //  If green tag enters green trigger run:
        if (trigCol.name == "Green Trigger")
        {
            if (collision.CompareTag("greenBlock"))    //  If the tag of the colliding object is greenBlock
            {
                Debug.Log("Inside green trigger. This is the " + collision.tag + " tag");
                GreenBlock();
            }
            else if (collision.tag != "greenBlock")
            {
                Debug.Log("Incorrect block!");
                wrongSound.Play();
                currentScene = SceneManager.GetActiveScene();
                SceneManager.LoadScene(currentScene.name);
            }
            else
            {
                Debug.Log("Broken");
            }
        }
        else if (trigCol.name == "Red Trigger")
        {
            if (collision.CompareTag("redBlock"))    //  If the tag of the colliding object is greenBlock
            {
                Debug.Log("Inside red trigger. This is the " + collision.tag + " tag");
                RedBlock();    
            }
            else if (collision.tag != "redBlock")
            {
                Debug.Log("Incorrect block!");
                wrongSound.Play();
                currentScene = SceneManager.GetActiveScene();
                SceneManager.LoadScene(currentScene.name);
            }
        }
        else if (trigCol.name == "Blue Trigger")
        {
            if (collision.CompareTag("blueBlock"))    //  If the tag of the colliding object is greenBlock
            {
                Debug.Log("Inside blue trigger. This is the " + collision.tag + " tag");
                BlueBlock();
            }
            else if (collision.tag != "blueBlock")
            {
                Debug.Log("Incorrect block!");
                wrongSound.Play();
                currentScene = SceneManager.GetActiveScene();
                SceneManager.LoadScene(currentScene.name);
            }
        }

        else if (trigCol.name == "Yellow Trigger")
        { 
            if (collision.CompareTag("greenBlock"))
            {
                Debug.Log("Inside yellow trigger. This is the " + collision.tag + " tag");
                platform = Instantiate(platform, spawnPointYellow.position, Quaternion.identity);
                correctSound.Play();

            }
            else if (collision.CompareTag("redBlock"))
            {
                Debug.Log("Inside yellow trigger. This is the " + collision.tag + " tag");
                platform = Instantiate(platform, spawnPointYellow1.position, Quaternion.identity);
                correctSound.Play();
            }
            else if (collision.tag == "blueBlock")
            {
                Debug.Log("Incorrect block!");
                wrongSound.Play();
                currentScene = SceneManager.GetActiveScene();
                SceneManager.LoadScene(currentScene.name);
            }
        }
        else if (trigCol.name == "White Trigger")
        {   //  && not working. Could spawn each platform as each box goes in
            if (collision.CompareTag("greenBlock"))
            {
                Debug.Log("Inside white trigger. This is the " + collision.tag + " tag");
                counter++;
                correctSound.Play();

            }
            else if (collision.CompareTag("redBlock"))
            {
                Debug.Log("Inside white trigger. This is the " + collision.tag + " tag");
                counter++;
                correctSound.Play();
            }
            else if (collision.CompareTag("blueBlock"))
            {
                Debug.Log("Inside white trigger. This is the " + collision.tag + " tag");
                counter++;
                correctSound.Play();
            }
        }

    }
 
    private void BlueBlock()
    {
        correctSound.Play();
        //platform = Instantiate(platform, spawnpointBlue.position, Quaternion.identity);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }

    private void RedBlock()
    {
        //  correct box, level2/3 complete
        platform = Instantiate(platform, spawnPointRed.position, Quaternion.Euler(0, 0, -2));
        correctSound.Play();
    }

    private void GreenBlock()
    {
        //  correct box, level1/3 complete
        platform = Instantiate(platform, spawnPointGreen.position, Quaternion.Euler(0, 0, -2));
        //  Set boxRenderer to be the Renderer component of the instantiated box
        //platform.transform.localScale = new Vector3(.75f, 0, 0);
        //platRenderer = platform.GetComponent<Renderer>(); //  box.tranform
        //platRenderer.material.color = Color.green;

        correctSound.Play();
    }
}
