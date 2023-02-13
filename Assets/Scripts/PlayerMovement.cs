using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
public class PlayerMovement : MonoBehaviour
{

    public float speed; 

    public void MovePlayer(bool moveRight)
    {
        if(moveRight) transform.position = transform.position + transform.right * Time.deltaTime * speed;
        if(!moveRight) transform.position = transform.position - transform.right * Time.deltaTime * speed;

    }
}
