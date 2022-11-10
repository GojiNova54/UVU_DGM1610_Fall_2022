using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public bool isGameOver;

    private GameObject gameOverText;

    public AudioSource levelMusic;

    public AudioSource audioSource;

    public AudioClip clip;

    public float volume = 0.5f;

    void Awake()
    {
        Time.timeScale = 1;
        isGameOver = false;
        levelMusic.Play();
    }


    void Start()
    {
        gameOverText = GameObject.Find("GameOverText");

        
    }

    
    void Update()
    {
        if (isGameOver)
        {
            EndGame(); // Start EndGame method
            levelMusic.Stop(); // Stops level music
            audioSource.PlayOneShot(audioSource.clip, volume); // Plays game over music

        }
        else
            gameOverText.gameObject.SetActive(false); // Keep UI text Game Over hidden
    }

    public void EndGame() 
    {
        gameOverText.gameObject.SetActive(true);
        Time.timeScale = 0; // Freeze time

        
    }
}
