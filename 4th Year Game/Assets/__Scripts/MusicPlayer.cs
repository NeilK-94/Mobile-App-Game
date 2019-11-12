using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
    //  create the music player as a singleton
    //  persist across scenes

    private void Awake()
    {
        SetupSingleton();
    }

    private void SetupSingleton()
    {
        //  find object of type musicplayer
        //  if there is one, use that instance
        //  destroy the one just created
        //  FindObjectOfType()

        if(FindObjectsOfType<MusicPlayer>().Length < 1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }
}
