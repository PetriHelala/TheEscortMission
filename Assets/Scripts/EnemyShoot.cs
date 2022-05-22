using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{

    
    [SerializeField] float range, timeToShoot, shotSpeed;
    [SerializeField] Transform enemyFirePoint, enemyFirePoint2;
    [SerializeField] private float speed;
    GameObject ball;
    Rigidbody2D rb;
    private float distanceToPlayer;
    public GameObject enemyBullet;
    
    IEnumerator ShootCoroutine;

    bool isShooting;

    [SerializeField] AudioSource _audiosource;

    // Start is called before the first frame update
    void Start()
    {
        ball = GameObject.Find("Ball");
        rb = GetComponent<Rigidbody2D>();
        _audiosource = GetComponent<AudioSource>();
        ShootCoroutine = Shoot();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        distanceToPlayer = Vector2.Distance(rb.transform.position, ball.transform.position);

        if (distanceToPlayer <= range && isShooting == false) {
            StartCoroutine(ShootCoroutine);
            isShooting = true;
        }
 
    }

    IEnumerator Shoot()
    {
        while (true) {
            yield return new WaitForSeconds(timeToShoot);
            Vector3 dist = (ball.transform.position - transform.position + (Vector3)ball.GetComponent<FollowScript>().velocity * speed).normalized * shotSpeed;
            GameObject newBullet = Instantiate(enemyBullet, enemyFirePoint.position, Quaternion.identity);
            GameObject newBullet2 = Instantiate(enemyBullet, enemyFirePoint2.position, Quaternion.identity);
            newBullet.GetComponent<Rigidbody2D>().velocity = dist;
            newBullet2.GetComponent<Rigidbody2D>().velocity = dist;
            _audiosource.Play();
            Destroy(newBullet, 2f);
            Destroy(newBullet2, 2f);
        }

        
    }

    
}
