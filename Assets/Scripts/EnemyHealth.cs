using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] float enemyHealth = 50f;
    [SerializeField] AudioClip hurtsound;
    [SerializeField] AudioClip deathsound;
    AudioSource _audiosource;

    // Start is called before the first frame update
    void Start()
    {
        _audiosource = GetComponent<AudioSource>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.tag == "Bullet") {
            enemyHealth -= 10f;
            _audiosource.PlayOneShot(hurtsound, 0.5f);
            Debug.Log($"{enemyHealth}");

        } 
        
        if (enemyHealth <= 0f) {
            _audiosource.PlayOneShot(deathsound, 0.3f);
            Destroy(gameObject, 0.2f);
            Debug.Log("dead");  

        }
    }
}
