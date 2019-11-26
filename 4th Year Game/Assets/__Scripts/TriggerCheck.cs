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
    public Transform spawnpointGreen;
    public Transform spawnpointRed;
    public Transform spawnpointBlue;
    public Renderer platRenderer;

    private Scene currentScene;

    [SerializeField]
    private AudioSource wrongSound, correctSound;

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

    }

    private void BlueBlock()
    {
        //  correct
        correctSound.Play();
        //platform = Instantiate(platform, spawnpointBlue.position, Quaternion.identity);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }

    private void RedBlock()
    {
        //  correct box, level2/3 complete
        platform = Instantiate(platform, spawnpointRed.position, Quaternion.identity);
        correctSound.Play();
    }

    private void GreenBlock()
    {
        //  correct box, level1/3 complete
        platform = Instantiate(platform, spawnpointGreen.position, Quaternion.identity);
        //  Set boxRenderer to be the Renderer component of the instantiated box
        //platform.transform.localScale = new Vector3(.75f, 0, 0);
        //platRenderer = platform.GetComponent<Renderer>(); //  box.tranform
        //platRenderer.material.color = Color.green;

        correctSound.Play();
    }
}
