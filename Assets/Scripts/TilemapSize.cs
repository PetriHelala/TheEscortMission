using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class TilemapSize : MonoBehaviour
{
    [SerializeField]
    GameObject RePosTileMap;
    Tilemap tilemap;

    void Start()
    { 
        tilemap = transform.GetChild(1).GetComponent<Tilemap>();
        tilemap.CompressBounds();
    }

    void Reposition(){
        RePosTileMap.transform.position = new Vector3
            (transform.position.x,transform.position.y + tilemap.size.y, transform.position.z);
    }
}
