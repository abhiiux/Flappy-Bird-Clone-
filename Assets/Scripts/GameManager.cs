using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManager : MonoBehaviour
{
   public GameObject gameOver;
   public static GameManager Instance { get; private set; }

   void Start()
   {
     Instance = this;
   }

   public static void Endgame()
   {
    Instance.gameOver.SetActive(true);
   }

   public void GotoNextLevel()
   {
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
   }

   public void GotoLastLevel()
   {
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
   }

   public static void Restart()
   {
    SceneManager.LoadScene(SceneManager.GetActiveScene().name);
   }

}
