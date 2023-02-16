using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraMovement : MonoBehaviour
{
    public GameObject target;
    private Vector3 camaraPosition;
    public float minPosition = 0;
    public float maxPosition = 18;

    private void Start()
    {
        camaraPosition = transform.position;
    }

    private void Update()
    {
        if(target.transform.position.x > minPosition && target.transform.position.x < maxPosition && target.transform.position.y < 5)
        {
            camaraPosition.x = target.transform.position.x;
            transform.position = camaraPosition;
            
        }
        else if (target.transform.position.x > minPosition && target.transform.position.x < maxPosition && target.transform.position.y > 5)
        {
            camaraPosition.x = target.transform.position.x;
            camaraPosition.y = 10;
            transform.position = camaraPosition;


        }
        else if (target.transform.position.y > 5)
        {
            camaraPosition.y = 10;
            transform.position = camaraPosition;

        }
        else if (target.transform.position.y < 5)
        {
            camaraPosition.y = 0;
            transform.position = camaraPosition;

        }

    }
}
