using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrierInstantiateAndDestruct : MonoBehaviour
{

    public GameObject barrierPrefab;
    Vector3[] spawnPositions = {new Vector3(0f, 11f, 0f), new Vector3(0f, 38.5f, 0f), new Vector3(0f, 65f, 0f), new Vector3(0f, 88f, 0f)};
    bool barrierHasSpawned;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time >= 0f && barrierHasSpawned == false) {
            BarrierInstantiate();
            barrierHasSpawned = true;
        }
    }

    void BarrierInstantiate()
    {
        for (int i = 0; i < spawnPositions.Length; i++) {
            Instantiate(barrierPrefab, spawnPositions[i], Quaternion.identity);
        }
    }
}
