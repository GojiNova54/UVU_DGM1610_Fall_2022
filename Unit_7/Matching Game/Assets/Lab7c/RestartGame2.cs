using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartGame2 : MonoBehaviour
{
    public void LoadGame() 
    {
        SceneManager.LoadScene("GameScene");
    }
}
