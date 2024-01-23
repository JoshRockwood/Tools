using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundAudio : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip backgroundMusic;
    private GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        audioSource.clip = backgroundMusic;
        audioSource.Play();
    }

    void Update()
    {
        if (gameManager.isGameOver == true)
        {
            audioSource.Stop();
        }
    }
}
