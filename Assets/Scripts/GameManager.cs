using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    public string currentScene;
    public string nextScene;
    public GameMusic gameMusic;
    
    private void Start()
    {
        gameMusic = FindObjectOfType<GameMusic>();
        string activeScene = SceneManager.GetActiveScene().name;
        print(activeScene);
    }
    public void Respawn()
    {
        SceneManager.LoadScene(currentScene);
    }

    public void MoveToNextLevel()
    {
        SceneManager.LoadScene(nextScene);
    }

    public void GameOver()
    {
        SceneManager.LoadScene("Game Over");
    }
}
