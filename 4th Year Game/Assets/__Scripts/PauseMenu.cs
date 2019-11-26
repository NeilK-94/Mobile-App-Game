using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
        pauseMenuUI.SetActive(false);    //  Enable the pause menu
        Time.timeScale = 1f;    //  Pause time
        isPaused = false;
    }

    public void LoadMenu() //  Back to main menu
    {
        Debug.Log("To main menu");
        SceneManager.LoadScene("Menu");

    }
}
