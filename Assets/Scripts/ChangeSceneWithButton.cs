using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeSceneWithButton : MonoBehaviour
{
   // [SerializeField] private string afterCollisionMenu;  
   public void LoadScene(string sceneName)
   {
      SceneManager.LoadScene(sceneName);
   }

   /* private void OnCollisionEnter(Collision collision)
   {
      SceneManager.LoadScene(afterCollisionMenu);
   } */
}
