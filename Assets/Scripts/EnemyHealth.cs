using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] float enemyHealth = 50f;
    [SerializeField] AudioSource _audiosource;
    [SerializeField] AudioSource _audiosource2;

    // Start is called before the first frame update
    void Start()
    {
        _audiosource = GetComponent<AudioSource>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.tag == "Bullet") {
            enemyHealth -= 10f;
            _audiosource2.Play();
            Debug.Log($"{enemyHealth}");

        } 
        
        if (enemyHealth <= 0f) {
            _audiosource.Play();
            Destroy(gameObject, 0.2f);
            Debug.Log("dead");  

        }
    }
}
