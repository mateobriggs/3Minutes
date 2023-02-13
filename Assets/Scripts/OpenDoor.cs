using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    public SpriteRenderer doorRenderer;

    private void OnTriggerEnter2D(Collider2D other)
    {
        print("tocaste el boton");
        doorRenderer.color = Color.red;
    }
}
