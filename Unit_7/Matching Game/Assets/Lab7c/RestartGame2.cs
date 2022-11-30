using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartGame2 : MonoBehaviour
{
    public void LoadGame() 
    {
        StartCoroutine(DelaySceneLoad());
    }

    IEnumerator DelaySceneLoad() 
    {
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene("GameScene");
    }
}
