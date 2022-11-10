using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour
{
    public AudioSource levelMusic;
    public AudioSource gameOverMusic;

    public bool levelSong = true;
    public bool GameOverMusic = false;

    public void LevelMusic() 
    {
        levelSong = true;
        GameOverMusic = false;
        levelMusic.Play();
    }

    public void GameOverSound() 
    {
        if (levelMusic.isPlaying)
            levelSong = false;

        {
            levelMusic.Stop();
        }

        if (!gameOverMusic.isPlaying && GameOverMusic == false) 
        {
            gameOverMusic.Play();
            GameOverMusic = true;
        }
    }

         
}

