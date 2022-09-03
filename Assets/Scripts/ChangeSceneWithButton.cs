using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeSceneWithButton : MonoBehaviour
{
   public string afterCollisionMenu;  
   public void LoadScene(string sceneName)
   {
      SceneManager.LoadScene(sceneName);
   }

   private void OnCollisionEnter(Collision collision)
   {
      SceneManager.LoadScene(afterCollisionMenu);
   }
}
