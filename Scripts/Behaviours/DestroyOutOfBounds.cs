using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    public float topBound;
    public float lowBound;
    private GameManager gameManager;
    private PlayAudio playAudio;
    void Awake()
    {
        // Reset time scale
        Time.timeScale = 1;
    }

    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        // Reference AudioSource game object
        playAudio = GameObject.Find("AudioSource").GetComponent<PlayAudio>();
    }
    // Update is called once per frame
    void Update()
    {
        // Destroys object if it passes topBound
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < lowBound)
        {
            Destroy(gameObject);
            gameManager.isGameOver = true;
            Time.timeScale = 0;

            // Play Game over sound effect
            if (playAudio != null)
            {
                playAudio.endGame();
            }
        }
    }
}
