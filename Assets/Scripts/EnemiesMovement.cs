using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

public class EnemiesMovement : MonoBehaviour
{
    public GameObject target;
    public float timeBetweenShots;
    private Vector3 dir;
    private Rigidbody2D enemie;
    public Rigidbody2D prefabBullet;
    public float shootForce;
 

    // Start is called before the first frame update
    private void Start()
    {
        
        enemie = GetComponent<Rigidbody2D>();
        StartCoroutine(EnemieShooting(dir));
        
    }

    // Update is called once per frame
    void Update()
    {
        dir = target.transform.position - transform.position;
        float angle = Vector3.Angle(dir, Vector3.left);
        transform.rotation = Quaternion.Euler(0, 0, 90 + angle);
    }

    private IEnumerator EnemieShooting(Vector3 dir)
    {
        while (true)
        {
            yield return new WaitForSeconds(timeBetweenShots);
            dir = (target.transform.position - transform.position).normalized;
            Vector3 bulletPosition = enemie.transform.position + dir.normalized * 1.5f;
            Rigidbody2D bullet = Instantiate(prefabBullet, bulletPosition, Quaternion.identity);
            bullet.AddForce(dir * shootForce, ForceMode2D.Impulse);
        }
    }
}
