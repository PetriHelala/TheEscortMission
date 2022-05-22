using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public float health;
    public float maxHealth = 100f;
    
    // Start is called before the first frame update
    void Start()
    {

        health = maxHealth;

    }

    public void Damage(float damage)
    {
        health += damage;

        if (health > maxHealth) {

            health = maxHealth;

        } else if (health <= 0f) {

            health = 0f;

            SceneManager.LoadScene("Stage");

        } 

    } 
}
