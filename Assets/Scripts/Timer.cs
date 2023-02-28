using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public static Timer timer;
    public float time;
    public TextMeshProUGUI timeText;
    private GameManager gameManager;    
    private void Awake()
    {
        if (timer == null)
        {
            timer = this;
        }
        else if (timer != this)
        {
            Destroy(gameObject);
        }

        DontDestroyOnLoad(gameObject);
        timeText = GetComponentInChildren<TextMeshProUGUI>();
        gameManager = FindObjectOfType<GameManager>();
    }
    

    void Update()
    {
        time -= Time.deltaTime;
        timeText.text = time.ToString("f0");
        if(time < 1)
        {
            gameManager.GameOver();
            Destroy(gameObject);
        }
        else if (SceneManager.GetActiveScene().name == "Win Menu")
        {
            Destroy(gameObject);
        }
    }
}
