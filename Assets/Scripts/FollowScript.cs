using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowScript : MonoBehaviour
{
    [SerializeField] Transform Player;
    [SerializeField] [Range(0.001f, 10f)] float followSharpness = 0.1f;

    Vector3 oldPosition;
    public Vector3 velocity;
    Vector3 _followOffset;
    float distance;

    void Start()
    {
        _followOffset = transform.position - Player.position;
    }

    void LateUpdate() 
    {
        distance = Vector3.Distance(Player.transform.position, transform.position);
        if(distance < 5){
            Vector3 targetPosition = Player.position + _followOffset;
            oldPosition = transform.position;
            
            transform.position += (targetPosition - transform.position) * followSharpness * Time.deltaTime;
            velocity = transform.position - oldPosition;
        }
    }
}

