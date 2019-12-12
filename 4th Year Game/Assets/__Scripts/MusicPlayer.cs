using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
 * This script creates the music player game object as a singleton. It will persist across all scenes
 * We use the Awake method to initialise before the start function.  The loading of a new Scene destroys all
 * current Scene objects. We call Object.DontDestroyOnLoad to preserve an Object during level loading. -Unity Docs
 */
public class MusicPlayer : MonoBehaviour
{

    private void Awake()    //  Call the singleton method 
    {
        SetupSingleton();
    }

    private void SetupSingleton()
    {
        //  find object of type musicplayer
        //  if there is one, use that instance
        //  destroy the one just created
        //  FindObjectOfType()

        if(FindObjectsOfType<MusicPlayer>().Length > 1)
        {
            Destroy(gameObject);
        }
        else
        {  
            DontDestroyOnLoad(gameObject); 
        }
    }
}
