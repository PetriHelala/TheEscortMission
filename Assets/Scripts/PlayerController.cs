using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;
    public Rigidbody2D rb;
    private Vector2 movement;

    void Start() 
    {
        
    }

    void Update()
    {

        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        movement = new Vector2(movement.x * speed, movement.y * speed).normalized;
    
        rb.MovePosition(rb.position + movement * speed * Time.fixedDeltaTime);
    }
 
}
