using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SettingsMenu : MonoBehaviour
{
    public AudioMixer soundTrack;
    public AudioMixer soundEffects;
    public Toggle toggle;

    public static bool isMuted = false;
    private float mute = 0f;

    public void SetVolume(float vol)
    {
        soundTrack.SetFloat("Volume", vol);
    }

    public void MuteVolume(float vol)
    {
        if (isMuted == false)    //  if the audio is not muted, mute it
        {
            soundTrack.SetFloat("Volume", -60f);
            isMuted = true;
        }
        else
        {
            soundTrack.SetFloat("Volume", vol);
            isMuted = false;
        }
    }

    public void MuteAffects(float vol)
    {
        if (isMuted == false)    //  if the audio is not muted, mute it
        {
            soundEffects.SetFloat("effectVolume", -60f);
            isMuted = true;
        }
        else
        {
            soundEffects.SetFloat("effectVolume", vol);
            isMuted = false;
        }
    }

}
