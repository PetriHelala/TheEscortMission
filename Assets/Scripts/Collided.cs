using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collided : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D C){
        if(C.tag == "Player")
            transform.parent.gameObject.SendMessage("Reposition");
    }
}