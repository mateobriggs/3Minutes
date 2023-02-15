using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpigStep : MonoBehaviour
{
    public float jumpingStepForce;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            other.attachedRigidbody.AddForce(Vector2.up * jumpingStepForce, ForceMode2D.Impulse);
        }
    }
}
