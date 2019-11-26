using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SettingsMenu : MonoBehaviour
{
    public AudioMixer audioMixer;
    public Toggle toggle;

    public static bool isMuted = false;

    private float mute = 0f;

    public void SetVolume(float vol)
    {
        audioMixer.SetFloat("Volume", vol);
    }

    public void MuteVolume(float vol)
    {
        if (isMuted == false)    //  if the audio is not muted, mute it
        {
            audioMixer.SetFloat("Volume", -40f);
            isMuted = true;
        }
        else
        {
            audioMixer.SetFloat("Volume", vol);
            isMuted = false;
        }
    }

}
