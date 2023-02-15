using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class MovePlataform : MonoBehaviour
{
    public Vector2 finalPos;
    private Vector2 initialPos;
    public float speed;
    private string objectTag;

    private void Start()
    {
        initialPos = transform.position;
        objectTag = gameObject.tag;
    }
    private void FixedUpdate()
    {
        if (objectTag == "Elevator")
        {
            transform.position = Vector2.MoveTowards(transform.position, finalPos, speed * Time.deltaTime);
            if (Mathf.Abs(transform.position.y - finalPos.y) < 0.001)
            {
                finalPos = initialPos;
                initialPos = transform.position;
            }
            
        }
        else if (objectTag == "MovablePlataform")
        {
            transform.position = Vector2.MoveTowards(transform.position, finalPos, speed * Time.deltaTime);
            if (Mathf.Abs(transform.position.magnitude - finalPos.magnitude) < 0.001)
            {

                finalPos = initialPos;
                initialPos = transform.position;
            }
        }
        else if (objectTag == "RunningEnemie")
        {
            transform.position = Vector2.MoveTowards(transform.position, finalPos, speed * Time.deltaTime);
            if (Mathf.Abs(transform.position.x - finalPos.x) < 0.001)
            {
                finalPos = initialPos;
                initialPos = transform.position;
            }
        }
    }
}
