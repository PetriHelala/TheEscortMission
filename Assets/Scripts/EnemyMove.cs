using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    public GameObject enemyPrefab;
    GameObject movingEnemy;
    Rigidbody2D rb;
    bool HasSpawned = false;

    private Vector3 spawnPosition = new Vector3(0f, 12f, 0f);
    private Vector3 pos1 = new Vector3(0f, 8.5f, 0f);

    IEnumerator MoveEnemyCoroutine;

    Vector3[] Positions = {new Vector3(-10f, 8.5f, 0f), new Vector3(10f, 8.5f, 0f)};

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Time.time >= 5.0f && HasSpawned == false) {
            HasSpawned = true;
            EnemySpawnAndMove(); 
        }
        
    }

    IEnumerator MoveEnemy(GameObject GO) 
    {
        while (GO) {
            for (int j = 0; j < Positions.Length; j++){
                if(GO)
                    yield return LerpFunction.LerpPosition(movingEnemy.transform, Positions[j], 3f);
                else{
                    StopLerping();
                    break;
                }
            }
       }
    }

    void StopLerping(){
        StopCoroutine(MoveEnemyCoroutine);
        Destroy(movingEnemy);
    }

    
    
    public void EnemySpawnAndMove() 
    {
        movingEnemy = Instantiate(enemyPrefab, spawnPosition, Quaternion.identity); 
        movingEnemy.transform.position = pos1;
        MoveEnemyCoroutine = MoveEnemy(movingEnemy);
        StartCoroutine(MoveEnemyCoroutine);
    }
}
