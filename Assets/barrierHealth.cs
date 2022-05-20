using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class barrierHealth : MonoBehaviour
{
    private float enemyHealth;

    // Start is called before the first frame update
    void Start()
    {
        enemyHealth = 100f;
    }

    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.tag == "Bullet") {
            enemyHealth -= 10f;

        } 
        
        if (enemyHealth <= 0f) {
            Destroy(gameObject, 0.2f);
             
        }
    }
}
