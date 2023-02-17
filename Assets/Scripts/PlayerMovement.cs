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
    private Animator animator;

    

    public void MovePlayer(bool moveRight)
    {
        animator = GetComponent<Animator>();
        animator.SetBool("RunningRight", false);
        animator.SetBool("RunningLeft", false);

        if (Physics2D.OverlapCircle(transform.position, radius, leftWallMask))
        {
            if (moveRight)
            {
                transform.position = transform.position + transform.right * Time.deltaTime * speed;
                animator.SetBool("RunningRight", true);
            }
        }
        else if (Physics2D.OverlapCircle(transform.position, radius, rightWallMask))
        {
            if (!moveRight)
            {
                transform.position = transform.position - transform.right * Time.deltaTime * speed;
                animator.SetBool("RunningLeft", true);

            }
        }
        else
        {
            if (moveRight)
            {
                transform.position = transform.position + transform.right * Time.deltaTime * speed;
                animator.SetBool("RunningRight", true);
            }
            if (!moveRight) 
            {
                transform.position = transform.position - transform.right * Time.deltaTime * speed;
                animator.SetBool("RunningLeft", true);

            }

        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(transform.position, radius);
    }
}
