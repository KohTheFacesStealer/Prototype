using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Audio : MonoBehaviour
{

    public AudioMixer MasterController;
    public AudioMixer MusicController;
    public AudioMixer SoundFXController;

    public void setMaster(float MasterVolume)
    {
        MasterController.SetFloat("MasterVolume", MasterVolume);
  
    }

    public void setMusic(float Music)
    {
        MusicController.SetFloat("Music", Music);
    }

    public void setSoundFX(float SoundFX)
    {
        SoundFXController.SetFloat("SoundFX", SoundFX);
    }
}
