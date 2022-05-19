using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{

    
    [SerializeField] float range, rangeOfShot, timeToShoot, shotSpeed;
    [SerializeField] Transform ball, enemyFirePoint;
    [SerializeField] GameObject movingEnemy;
    [SerializeField] Rigidbody2D rb;
    private float distanceToPlayer;
    public GameObject enemyBullet;
    

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        distanceToPlayer = Vector2.Distance(rb.transform.position, ball.position);

        if (distanceToPlayer <= range) {
            StartCoroutine(Shoot());
        }
 
    }

    IEnumerator Shoot()
    {
        yield return new WaitForSeconds(timeToShoot);
        GameObject newBullet = Instantiate(enemyBullet, enemyFirePoint.position, Quaternion.identity);
        newBullet.GetComponent<Rigidbody2D>().velocity = new Vector2(ball.transform.position.x, shotSpeed);
    }

    
}
