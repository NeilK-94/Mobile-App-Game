using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerCheck : MonoBehaviour
{
    //public GameObject block1;
    public Collider2D trigCol;

    private Scene currentScene;

    public void Start()
    {
        trigCol = GetComponent<Collider2D>();
    }
    public void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag=="greenBlock")    //  If the tag of the colliding object is greenBlock
        {
            Debug.Log("Green block");
            //  Code here to finish level
        }
        else   //   Else reload the scene
        {
            Debug.Log("Not green block");

            currentScene = SceneManager.GetActiveScene();
            SceneManager.LoadScene(currentScene.name);
        }
    }
}
