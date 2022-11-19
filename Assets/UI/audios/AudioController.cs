using UnityEngine;

public class AudioController : MonoBehaviour
{
    
    public AudioSource AudioSource;

    void Start()
    {
        DontDestroyOnLoad(gameObject);
        AudioSource.Play();
    }
}
