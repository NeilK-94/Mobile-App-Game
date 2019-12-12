using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
/*
 * The settings menu script is purely responsible for the manipulation of our sound. It has two different
 * audioMixers. One for the main soundtrack and one for the sound effets. I did this so the user could enable one, the 
 * other, or neither. We use the audio mixers exposed parameters to change the volume. 
 */
public class SettingsMenu : MonoBehaviour
{
    public AudioMixer soundTrack;
    public AudioMixer soundEffects;
    public Toggle toggle;

    public static bool isMuted = false; //  Check to see if the audio is muted
    private float mute = -60f;

    public void SetVolume(float vol)
    {
        soundTrack.SetFloat("Volume", vol);
    }

    public void MuteVolume(float vol)
    {
        if (isMuted == false)    //  if the audio is not muted, mute it
        {
            soundTrack.SetFloat("Volume", mute);
            isMuted = true; //  Set isMuted to true 
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
            soundEffects.SetFloat("effectVolume", mute);
            isMuted = true;
        }
        else
        {
            soundEffects.SetFloat("effectVolume", vol);
            isMuted = false;
        }
    }

}
