using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; // Text mesh pro namespace added to acces the Unity libraries for UI

public class ScoreManager : MonoBehaviour
{
    public int score; // Keep score value
    public TextMeshProUGUI scoreText; // Visual Text element to be modified

    public void IncreaseScore(int amount) // increases the score by a predetermined amount set in score variable
    {
        score += amount;
        UpdateScoreText();
    }

    public void DecreaseScore(int amount) // This method decreases the score by a predetermined amount set in score variable
    {
        score -= amount;
        UpdateScoreText();
    }

    public void UpdateScoreText() // This method updates the score in the HUD UI Text
    {
        scoreText.text = "Score: " + score; 
    }
}
