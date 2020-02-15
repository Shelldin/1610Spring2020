using UnityEngine;
using UnityEngine.SceneManagement;

public class UIButtons : MonoBehaviour
{
   public void RestartLevel()
   {
      SceneManager.LoadScene(SceneManager.GetActiveScene().name);
      Debug.Log("you reset the level");
   }

   public void QuitGame()
   {
      Application.Quit();
      Debug.Log("you quit the game... coward.");
   }
}
