using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
/*
 * The Main Menu script. This either plays the game or quits the application depending on the button
 */
public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        Time.timeScale = 1f;
    }

    public void Quit()
    {
        Debug.Log("Quit!");
        Application.Quit();
    }
}
