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
        if(target.transform.position.x > minPosition && target.transform.position.x < maxPosition)
        {
            camaraPosition.x = target.transform.position.x;
            transform.position = camaraPosition;
        }
    }
}
