using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{

    public ScoreManager scoreManager; // Stores reference to score manager

    public int scoreToGive;

    

    

    void Start()
    {
        
        
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>(); // Find ScoreManager gameobject and reference ScoreManager script
    }
    void OnTriggerEnter(Collider other) // Once the Trigger has been entered, records collision in the argument var "other"
    {
        scoreManager.IncreaseScore(scoreToGive); // Increases score
        AudioManager.Instance.PlaySFX("Explosion"); // Plays sound when UFO is destroyed
        Destroy(gameObject);
        
    }
}
