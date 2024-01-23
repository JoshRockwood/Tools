using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAudio : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip laserEffect;
    public AudioClip explosion;
    public AudioClip buttonClick;
    public AudioClip gameOver;
    public AudioClip powerUp;

    // Function to play laser bolt sound effect 
    public void laserBolt()
    {
        audioSource.clip = laserEffect;
        audioSource.Play();
    }

    // Function to play explosion sound effect
    public void shipDestroyed()
    {
        audioSource.clip = explosion;
        audioSource.Play();
    }

    // Function to play start/quit game sound effects
    public void startGame()
    {
        audioSource.clip = buttonClick;
        audioSource.Play();
    }

    // Function to play Game Over sound effects
    public void endGame()
    {
        audioSource.clip = gameOver;
        audioSource.Play();
    }

    // Function to play powerup sound effect
    public void Upgrade()
    {
        audioSource.clip = powerUp;
        audioSource.Play();
    }
}
