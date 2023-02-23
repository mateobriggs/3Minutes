using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextLevel : MonoBehaviour
{
    private GameManager gameManager;
    private SpriteRenderer spriteRenderer;
    private OpenDoor openDoor;

    private void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        openDoor = FindObjectOfType<OpenDoor>();
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if(openDoor.doorOpen)
        {
            if (other.gameObject.tag == "Player")
            {
                gameManager.MoveToNextLevel();
            }
        }
    }
}
