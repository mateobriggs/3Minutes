using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraMovement : MonoBehaviour
{
    public GameObject target;
    private float offset;
    private Vector3 camaraPosition;
    private void Start()
    {
        camaraPosition = transform.position;
        offset = Mathf.Abs(camaraPosition.x - target.transform.position.x);
    }

    private void Update()
    {
        camaraPosition.x = target.transform.position.x + offset;
        transform.position = camaraPosition;
    }
}
