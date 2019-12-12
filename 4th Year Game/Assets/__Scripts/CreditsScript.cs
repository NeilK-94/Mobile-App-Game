using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
/*
 * Just a script to signal the end of the game. The load menu is method is called once the final box has been filled
 */

public class CreditsScript : MonoBehaviour
{
    public void LoadMenu() //  Back to main menu
    {
        Debug.Log("To main menu");
        SceneManager.LoadScene("Menu");
    }
}
