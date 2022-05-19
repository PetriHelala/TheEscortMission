using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Enemy") {
            Destroy(this.gameObject, 0f);
        } else {
            Destroy(this.gameObject, 2f);
        }
    }

    void OnCollisionEnter2D(Collision2D other) {
  
        

        Destroy(gameObject, 1f);

        
        
    }
}
