using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UI_Manager : MonoBehaviour
{

    public void SwitchScene(string sceneName) 
    {
        SceneManager.LoadScene(sceneName);

        
    }

    public void ExitGame()
    {
        
        Application.Quit();
        
    }

}
