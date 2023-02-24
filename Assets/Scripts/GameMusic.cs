using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMusic : MonoBehaviour
{
    public static GameMusic gameMusic;
    private void Awake()
    {
        if(gameMusic == null)
        {
            gameMusic = this;
        }else if(gameMusic != this)
        {
            Destroy(gameObject);
        }

        DontDestroyOnLoad(gameObject);
    }
}
