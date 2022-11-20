using UnityEngine;

public class RainScript : MonoBehaviour
{
    public AudioSource RainSource;

    public AudioClip[] AudioRain;
    // Start is called before the first frame update
    void Start()
    {
        AudioClip audioClip = AudioRain[0];
        RainSource.clip = audioClip;
        RainSource.Play();
    }
}
