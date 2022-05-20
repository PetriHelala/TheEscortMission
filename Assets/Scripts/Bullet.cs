using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(this.gameObject, 2f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Enemy") {
            Destroy(this.gameObject, 0f);
        } else {
            Destroy(this.gameObject, 3f);
        }

        if (other.tag == "Barrier") {
            Destroy(this.gameObject);
        }
    }
}
