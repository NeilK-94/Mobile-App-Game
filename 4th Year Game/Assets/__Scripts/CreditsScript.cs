using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CreditsScript : MonoBehaviour
{
    public void LoadMenu() //  Back to main menu
    {
        Debug.Log("To main menu");
        SceneManager.LoadScene("Menu");
    }
}
