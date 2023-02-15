using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillPlayer : MonoBehaviour
{
    private GameManager gameManager;

    private void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        
            if (other.gameObject.tag == "Player")
            {
                gameManager.Respawn();
            }
    }
}
