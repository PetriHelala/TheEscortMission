using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowScript : MonoBehaviour
{
    [SerializeField] Transform Player;
    [SerializeField] [Range(0.001f, 1)] float followSharpness = 0.1f;

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

