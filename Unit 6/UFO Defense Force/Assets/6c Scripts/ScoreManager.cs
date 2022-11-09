using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{

    public int score; // Keeps score value

    public TextMeshProUGUI scoreText; // Visual text to be modified
    public void IncreaseScore(int amount) // When called, increases the score by a predetermined amount set in score variable
    {
        score += amount;
        UpdateScoreText();
    }

    
    public void DecreaseScore(int amount) // When called, decreases the score
    {
        score -= amount;
        UpdateScoreText();
    }

    public void UpdateScoreText() // Updates the score in the HUD UI Text
    {
        scoreText.text = "Score: "+ score;
    }
}
