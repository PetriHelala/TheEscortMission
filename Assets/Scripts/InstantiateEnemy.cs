using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateEnemy : MonoBehaviour
{

    [SerializeField] GameObject enemyPrefab;
    Vector3[] spawnPositions = {new Vector3(0f, 27f, 0f), new Vector3(0f, 47f, 0f), new Vector3(0f, 67f, 0f), new Vector3(0f, 87f, 0f), new Vector3(0f, 107f, 0f)};
    [SerializeField] bool movingEnemy;

    // Start is called before the first frame update
    void Start()
    {
        movingEnemy = false;
    }

    // Update is called once per frame
    void Update()
    {
        Spawning();
    }

    public void Spawning()
    {
        if (Time.time > 5f && !movingEnemy){
            
            for (int j = 0; j < spawnPositions.Length; j++) {
                Instantiate(enemyPrefab, spawnPositions[j], Quaternion.identity);
            }
            movingEnemy = true;
        }
    }
}
