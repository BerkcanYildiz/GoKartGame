
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartMenu : MonoBehaviour
{   
    
    public string afterCollisionLevel;

    public string mainMenu;
    
    public void restartGame()
    {
        
        SceneManager.LoadScene(afterCollisionLevel);
    }

    public void MainMenuButton()
    {
        SceneManager.LoadScene(mainMenu);
    }
}
