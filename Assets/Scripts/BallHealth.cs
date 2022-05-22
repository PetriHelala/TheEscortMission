using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallHealth : MonoBehaviour
{
    [SerializeField] AudioClip hurtsound;
    [SerializeField] AudioClip deathsound;
    AudioSource _audiosource;
    public float health;
    public float maxHealth = 100f;

    // Start is called before the first frame update
    void Start()
    {
        _audiosource = GetComponent<AudioSource>();
        health = maxHealth;

    }

    public void Damage(float damage)
    {
        health += damage;
        
        _audiosource.PlayOneShot( hurtsound, 0.5f);
        
        if (health > maxHealth) {

            health = maxHealth;

        } else if (health <= 0f) {

            _audiosource.PlayOneShot( deathsound, 0.5f);

            health = 0f;

            SceneManager.LoadScene("Stage");

        } 

    } 
}
