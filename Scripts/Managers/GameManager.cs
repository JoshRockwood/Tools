using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public bool isGameOver;
    private GameObject gameOverText;

    void Awake()
    {
        Time.timeScale = 1;
        isGameOver = false;
    }
    // Start is called before the first frame update
    void Start()
    {
        gameOverText = GameObject.Find("GameOverText");
    }

    // Update is called once per frame
    void Update()
    {
        if (isGameOver)
        {
            // Start endgame method
            EndGame();
        }
        else
        {
            // Keep UI text Game Over hidden
            gameOverText.gameObject.SetActive(false);
        }
    }

    public void EndGame()
    {
        // Make GameOver text appear
        gameOverText.gameObject.SetActive(true);
        // Freeze time
        Time.timeScale = 0;
    }
}
