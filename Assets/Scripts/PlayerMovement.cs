using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
public class PlayerMovement : MonoBehaviour
{

    public float speed;
    public float radius;
    public LayerMask leftWallMask;
    public LayerMask rightWallMask;

    public void MovePlayer(bool moveRight)
    {
        if (Physics2D.OverlapCircle(transform.position, radius, leftWallMask))
        {
            if (moveRight) transform.position = transform.position + transform.right * Time.deltaTime * speed;
        }
        else if (Physics2D.OverlapCircle(transform.position, radius, rightWallMask))
        {
            if (!moveRight) transform.position = transform.position - transform.right * Time.deltaTime * speed;
        }
        else
        {
            if (moveRight) transform.position = transform.position + transform.right * Time.deltaTime * speed;
            if (!moveRight) transform.position = transform.position - transform.right * Time.deltaTime * speed;
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(transform.position, radius);
    }
}
