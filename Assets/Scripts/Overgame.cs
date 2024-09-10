using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Overgame : MonoBehaviour
{
  public void TryAgain()
  {
    GameManager.Restart();
  }

  public void Quit()
  {
    Application.Quit();
  }
}
