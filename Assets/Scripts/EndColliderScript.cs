using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndColliderScript : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D other) {
        
        if (other.tag == "Player") {
            Debug.Log("Ending Game");
            SceneManager.LoadScene("Menu");
        }
    }

}
