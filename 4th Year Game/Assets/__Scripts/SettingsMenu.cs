using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SettingsMenu : MonoBehaviour
{
    public AudioMixer audioMixer;
    public Toggle toggle;

    public void SetVolume(float vol)
    {
        audioMixer.SetFloat("Volume", vol);
    }
}
