using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowScript : MonoBehaviour
{
    [SerializeField] Transform Player;
    [SerializeField] float followSharpness = 0.1f;

    Vector3 _followOffset;

    void Start()
    {
        _followOffset = transform.position - Player.position;
    }

    void LateUpdate() 
    {
        Vector3 targetPosition = Player.position + _followOffset;
        transform.position += (targetPosition - transform.position) * followSharpness;
    }
}

