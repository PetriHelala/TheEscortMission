using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    private float enemyHealth;

    // Start is called before the first frame update
    void Start()
    {
        enemyHealth = 50f;
    }

    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.tag == "Bullet") {

            enemyHealth -= 10f;

        } else if (enemyHealth == 0f) {

            Destroy(this.gameObject, 0.2f);
            
        }
    }
}
