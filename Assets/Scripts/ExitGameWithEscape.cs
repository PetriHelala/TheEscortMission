using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ExitGameWithEscape : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ReturnToMainMenu();
    }

    public void ReturnToMainMenu() 
    {
        if (Input.GetKeyDown(KeyCode.Escape) || Input.GetButtonDown("Fire3")) {
            // Application.Quit();
            SceneManager.LoadScene("Menu");
        }
    }
}
