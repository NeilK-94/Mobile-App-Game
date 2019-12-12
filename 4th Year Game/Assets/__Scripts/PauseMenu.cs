using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
/* 
 * The pause menu script. This script allows the player to access the pause menu By pressing the escape key.
 * It uses a boolean to check if the game is paused or not, then we use the Time class to pause or set the game time
 * and the SceneManager class to load the menu scene * 
 */
public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenuUI;
    public static bool isPaused = false;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))   //  If escape is pressed
        {
            if(isPaused)    //  if game is already paused, then resume
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
        
    }

    void Pause()
    {
        pauseMenuUI.SetActive(true);    //  Enable the pause menu
        Time.timeScale = 0f;    //  Pause time
        isPaused = true;    
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);    //  Disable the pause menu
        Time.timeScale = 1f;    //  Reset time to normal
        isPaused = false;
    }

    public void LoadMenu() //  Back to main menu
    {
        Debug.Log("To main menu");
        SceneManager.LoadScene("Menu");
        //  Cancel audio to avoid overlapping 
    }
}
