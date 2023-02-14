using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    public GameObject player;
    private Vector3 startPosition;
    public string currentScene;
    public string nextScene;

    public void Respawn()
    {
        player.transform.position = startPosition;
        SceneManager.LoadScene(currentScene);
    }

    public void MoveToNextLevel()
    {
        SceneManager.LoadScene(nextScene);
    }
}
