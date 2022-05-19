using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{

    public float range, timeToShoot, shotSpeed;
    private float distanceToPlayer;
    public Transform ball, enemyFirePoint;
    public GameObject enemyBullet;
    GameObject movingEnemy;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        distanceToPlayer = Vector2.Distance(movingEnemy.transform.position, ball.position);

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
