using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuMusic : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip backgroundMusic;
    // Start is called before the first frame update
    void Start()
    {
        audioSource.clip = backgroundMusic;
        audioSource.Play();
    }
}
