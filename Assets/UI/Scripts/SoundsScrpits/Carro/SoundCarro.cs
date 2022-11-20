using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundCarro : MonoBehaviour
{
    public AudioSource soundCarroSource;

    public AudioClip[] audioCarro;
    // Start is called before the first frame update
    void Start()
    {
        AudioClip audioClip = audioCarro[0];
        soundCarroSource.clip = audioClip;
        soundCarroSource.Play();
    }
}
