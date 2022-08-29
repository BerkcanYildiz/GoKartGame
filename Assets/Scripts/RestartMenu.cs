using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartMenu : MonoBehaviour
{   
    
    public string afterCollisionLevel;

    public string mainMenu;
    // Update is called once per frame
    void Update()
    {
        
    }

    public void restartGame()
    {
        
        SceneManager.LoadScene(afterCollisionLevel);
    }

    public void MainMenuButton()
    {
        SceneManager.LoadScene(mainMenu);
    }
}
