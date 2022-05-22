using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] AudioSource _audiosource;
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
        _audiosource.Play();
        
        if (health > maxHealth) {

            health = maxHealth;

        } else if (health <= 0f) {

            health = 0f;

            SceneManager.LoadScene("Stage");

        } 

    } 
}
