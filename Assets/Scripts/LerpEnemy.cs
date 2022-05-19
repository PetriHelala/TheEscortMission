using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LerpEnemy : MonoBehaviour
{
    public GameObject enemyPrefab;
    GameObject movingEnemy;
    Rigidbody2D rb;
    bool HasSpawned = false;

    private Vector3 spawnPosition = new Vector3(0f, 12f, 0f);
    private Vector3 pos1 = new Vector3(0f, 8.5f, 0f);
    private Vector3 pos2 = new Vector3(-10f, 8.5f, 0f);
    private Vector3 pos3 = new Vector3(10f, 8.5f, 0f);

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
    
    public void EnemySpawnAndMove() 
    {
        movingEnemy = Instantiate(enemyPrefab, spawnPosition, Quaternion.Euler(0f, 0f, 0f)); 
        movingEnemy.transform.position = pos1;
        StartCoroutine(MoveEnemy());
    }
}
