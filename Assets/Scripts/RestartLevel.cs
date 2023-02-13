using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartLevel : MonoBehaviour
{
    public GameObject player;
    private Vector3 startPosition;
    public string currentScene;
    private void Start()
    {
        startPosition = player.transform.position;
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        player.transform.position = startPosition;
        SceneManager.LoadScene(currentScene);
    }
}
