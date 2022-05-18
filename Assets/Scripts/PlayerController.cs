using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float speed = 5f;
    [SerializeField] Rigidbody2D rb;
    private Vector2 movement;

    void Start() 
    {
        
    }

    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        movement = new Vector2(movement.x * speed, movement.y * speed).normalized;
<<<<<<< HEAD
    }
 
    void FixedUpdate() 
    {
        rb.MovePosition(rb.position + movement * speed * Time.fixedDeltaTime);
    }
=======
    
        rb.MovePosition(rb.position + movement * speed * Time.fixedDeltaTime);
    }
 
>>>>>>> f70bc69841bf87ccdcb6309b5af08f80e7fd2171
}
