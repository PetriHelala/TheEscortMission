using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{

    GameObject Player;
    GameObject Ball;
    PlayerHealth _playerhealth;
    BallHealth _ballhealth;
    public Rigidbody2D rb;

    private float attackDamage = 20f;

    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.Find("Player");
        _playerhealth = Player.GetComponent<PlayerHealth>();

        Ball = GameObject.Find("Ball");
        _ballhealth = Ball.GetComponent<BallHealth>();

        Destroy(gameObject, 3f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Player") {
            _playerhealth.SendMessage("Damage", -attackDamage);
            Debug.Log("Damage Received by Player");
            Destroy(gameObject, 0f);
        }
        
        if (other.tag == "Ball") {
            _ballhealth.SendMessage("Damage", -attackDamage);
            Debug.Log("Damage Received By Ball");
            Destroy(gameObject, 0f);
        }
    }
}
