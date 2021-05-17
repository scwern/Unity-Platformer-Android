using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Volume : MonoBehaviour
{

    private void Start()
    {
        
    }
    public AudioMixerGroup Mixer;
    // Start is called before the first frame update
    public void ChangeMusic(float volume1)
    {
        Mixer.audioMixer.SetFloat("MusicVolume", Mathf.Log10 (volume1) * 20);
        // Mixer.audioMixer.SetFloat("MusicVolume", Mathf.Lerp(-80, 0, volume1));
        //PlayerPrefs.SetFloat("MisucVolume", enabled ? 1 : 0);
    }

    // Update is called once per frame
    public void ChangeVolume(float volume)
    {
        Mixer.audioMixer.SetFloat("SoundVolume", Mathf.Log10(volume) * 20);
        // Mixer.audioMixer.SetFloat("SoundVolume", Mathf.Lerp(-80, 0, volume));
        //PlayerPrefs.SetFloat("SoundVolume", enabled ? 1 : 0);
    }
}
