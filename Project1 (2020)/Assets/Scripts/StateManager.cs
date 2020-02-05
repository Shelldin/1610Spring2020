
using UnityEngine;
using UnityEngine.SceneManagement;

public class StateManager : MonoBehaviour
{
   public bool gameIsOver = false;

   public float delay = 1.5f;

   public void GameOver()
   {
      if (gameIsOver == false)
      {
         gameIsOver = true;
         Invoke("ResetGame", delay);
      }
   }

   private void ResetGame()
   {
      SceneManager.LoadScene(SceneManager.GetActiveScene().name);
   }
}
