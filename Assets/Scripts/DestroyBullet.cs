using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBullet : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other != null)
        {
            Destroy(gameObject);
        }
    }
}
