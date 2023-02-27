using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMusic : MonoBehaviour
{
    public static GameMusic gameMusic;
    private void Awake()
    {


        if (gameMusic == null)
        {
            gameMusic = this;
        }
        else if (gameMusic != this)
        {
            Destroy(gameObject);
        }

        DontDestroyOnLoad(gameObject);


    }

    private void Update()
    {
        if (SceneManager.GetActiveScene().name == "Game Over")
        {
            print("game over");
            Destroy(gameObject);
        }
    }
}
