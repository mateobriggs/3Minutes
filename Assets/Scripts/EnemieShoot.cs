using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemieShoot : MonoBehaviour
{
    public float timeBetweenShots;
    public Vector2 dir;
    private Rigidbody2D enemie;
    public Rigidbody2D prefabBullet;
    public float shootForce;
    void Start()
    {
        enemie = GetComponent<Rigidbody2D>();
        StartCoroutine(EnemieShooting(dir));
    }

    private IEnumerator EnemieShooting(Vector2 dir)
    {
        while (true)
        {
            yield return new WaitForSeconds(timeBetweenShots);
            Vector2 bulletPosition = new Vector2 (enemie.transform.position.x, enemie.transform.position.y) + dir.normalized * 2;
            Rigidbody2D bullet = Instantiate(prefabBullet, bulletPosition, Quaternion.identity);
            bullet.AddForce(dir.normalized * shootForce, ForceMode2D.Impulse);
        }
    }
}
