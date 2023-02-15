using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextLevel : MonoBehaviour
{
    private GameManager gameManager;
    private SpriteRenderer spriteRenderer;

    private void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
        spriteRenderer = GetComponent<SpriteRenderer>();    
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(spriteRenderer.color == Color.red)
        {
            if (other.gameObject.tag == "Player")
            {
                gameManager.MoveToNextLevel();
            }
        }
    }
}
