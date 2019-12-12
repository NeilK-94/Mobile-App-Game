using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
/*
* This script is just in case of bugs or the player breaking the game. If they manage to leave the evel area they 
* will hit this collider and the scene will restart.
*/

public class LevelBoundary : MonoBehaviour
{
    public GameObject player;   //  Find the player
    private Scene currentScene;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        currentScene = SceneManager.GetActiveScene();   //  Set currentscene to the active scene
        if (player)
        {
            SceneManager.LoadScene(currentScene.name);  //  Reload the scene
        }
    }
}
