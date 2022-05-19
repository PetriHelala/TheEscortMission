using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float speed = 5f;
    [SerializeField] Rigidbody2D rb;
    
    private Vector2 movement;

    bool LockControls = false;

    void Start() 
    {
        
    }

    void Update()
    {
        
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        movement = new Vector2(movement.x * speed, movement.y * speed).normalized;
    }
 
    void FixedUpdate()
    {
        if(LockControls == false)
            rb.MovePosition(rb.position + movement * speed * Time.fixedDeltaTime);
    }

    void LockedControls(){
        LockControls = true;
        Invoke("ReleaseControls", 1f);
    }

    void ReleaseControls(){
        LockControls = false;
    }

    
}
