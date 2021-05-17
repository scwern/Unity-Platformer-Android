using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundEffector : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip jumpS, winS, dieS, stepS;

    public void PlayJumpS()
    {
        audioSource.PlayOneShot(jumpS);
    }
    public void PlayWinS()
    {
        audioSource.PlayOneShot(winS);
    }
    public void PlayDieS()
    {
        audioSource.PlayOneShot(dieS);
    }
    

}
