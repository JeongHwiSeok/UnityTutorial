using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound
{
    public AudioClip[] audioClips;
}

public class SoundManager : MonoBehaviour
{
    [SerializeField] AudioSource bgmSource;
    [SerializeField] AudioSource sfxSource;

    public static SoundManager instance = null;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void Sound(AudioClip audioClip)
    {
        sfxSource.PlayOneShot(audioClip);
    }
}
