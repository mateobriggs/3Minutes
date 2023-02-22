using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    public GameObject player;
    public string currentScene;
    public string nextScene;

    public void Respawn()
    {
        SceneManager.LoadScene(currentScene);
    }

    public void MoveToNextLevel()
    {
        SceneManager.LoadScene(nextScene);
    }
}
