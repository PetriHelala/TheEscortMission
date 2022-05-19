using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    public GameObject enemyPrefab;
    GameObject movingEnemy;
    Rigidbody2D rb;
    bool HasSpawned = false;

    private Vector3 spawnPosition = new Vector3(0f, 12f, 0f);
    private Vector3 pos1 = new Vector3(0f, 8.5f, 0f);
    private Vector3 pos2 = new Vector3(-10f, 8.5f, 0f);
    private Vector3 pos3 = new Vector3(10f, 8.5f, 0f);

    public float range, timeToShoot, shotSpeed;
    private float distanceToPlayer;
    public Transform ball, enemyFirePoint;
    public GameObject enemyBullet;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        movingEnemy = enemyPrefab;
    }

    // Update is called once per frame
    void Update()
    {

        if (Time.time >= 5.0f && HasSpawned == false) {
            HasSpawned = true;
            EnemySpawnAndMove(); 
        }

        distanceToPlayer = Vector2.Distance(movingEnemy.transform.position, ball.position);

        if (distanceToPlayer <= range) {
            StartCoroutine(Shoot());
        }
        
    }

    IEnumerator MoveEnemy() 
    {
        while (true) {
            
            yield return LerpFunction.LerpPosition(movingEnemy.transform, pos2, 1f);

            yield return LerpFunction.LerpPosition(movingEnemy.transform, pos3, 1f);

            yield return LerpFunction.LerpPosition(movingEnemy.transform, pos2, 1f);

            yield return LerpFunction.LerpPosition(movingEnemy.transform, pos3, 1f);
 
        }
    }

    IEnumerator Shoot()
    {
        yield return new WaitForSeconds(timeToShoot);
        GameObject newBullet = Instantiate(enemyBullet, enemyFirePoint.position, Quaternion.identity);
        newBullet.GetComponent<Rigidbody2D>().velocity = new Vector2(ball.transform.position.x, shotSpeed);
    }
    
    public void EnemySpawnAndMove() 
    {
        movingEnemy = Instantiate(enemyPrefab, spawnPosition, Quaternion.identity); 
        movingEnemy.transform.position = pos1;
        StartCoroutine(MoveEnemy());
    }
}
