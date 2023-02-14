using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartElevator : MonoBehaviour
{
    public float maxHeight;
    public float minHeight;
    public LayerMask elevatorMask;
    private float radius = 0.36f;
    public GameObject elevator;

    public void RaiseElevator()
    {
        if (Physics2D.OverlapCircle(transform.position + Vector3.down * 0.5f, radius, elevatorMask))   
        {
            if (elevator.transform.position.y <= maxHeight)
            {
                elevator.transform.position = Vector3.MoveTowards(elevator.transform.position, new Vector3(1, 2, 0), Time.deltaTime * 0.5f);
                
                
            }
        }
    }
}
