using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallHealth : MonoBehaviour
{
    public float health;
    public float maxHealth = 100f;

    [SerializeField] AudioSource _audiosource;
    
    // Start is called before the first frame update
    void Start()
    {
        _audiosource = GetComponent<AudioSource>();
        health = maxHealth;

    }

    public void Damage(float damage)
    {
        health += damage;
        _audiosource.Play();
        
        if (health > maxHealth) {

            health = maxHealth;

        } else if (health <= 0f) {

            health = 0f;

            SceneManager.LoadScene("Stage");

        } 

    } 
}
