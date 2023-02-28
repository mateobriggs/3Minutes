using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LevelCounter : MonoBehaviour
{
    private static LevelCounter levelCounter;
    private TextMeshProUGUI levelCounterText;
    private void Awake()
    {
        if(levelCounter == null)
        {
            levelCounter = this;
        }else if(levelCounter != this)
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);
        levelCounterText = GetComponentInChildren<TextMeshProUGUI>();   
    }

    // Update is called once per frame
    void Update()
    {
        levelCounterText.text = SceneManager.GetActiveScene().name + "/6";
        if(SceneManager.GetActiveScene().name == "Win Menu" || SceneManager.GetActiveScene().name == "Game Over")
        {
            Destroy(gameObject);
        }
    }
}
