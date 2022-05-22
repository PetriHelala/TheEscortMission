using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndColliderScript : MonoBehaviour
{

    AudioSource _audiosource;

    private void Start() {
        _audiosource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D other) {
        
        if (other.tag == "Player") {
            Debug.Log("Ending Game");
            SceneManager.LoadScene("Menu");
        }
    }

}
