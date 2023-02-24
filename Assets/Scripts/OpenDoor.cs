using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    public Animator animator;
    public bool doorOpen = false;
    public SpriteRenderer spriteRenderer;
    public Sprite newSprite;
    public AudioSource buttonPressed;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (!doorOpen)
            {
                buttonPressed.Play();
                animator.SetBool("Button Pressed", true);
                doorOpen = true;
                spriteRenderer.sprite = newSprite;
            }
            
        }
    }
}
