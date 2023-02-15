using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeactivateEnemie : MonoBehaviour
{
    public List<GameObject> enemies = new List<GameObject>();


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            foreach(GameObject go in enemies)
            {
                go.SetActive(false);
            }
        }
    }
}
