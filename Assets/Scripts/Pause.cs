using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pause : MonoBehaviour
{
    public GameObject pause;


    public void pausing()
    {
      pause.SetActive(true);
      Time.timeScale = 0f;
    }

    public void unpausing()
    {
     pause.SetActive(false);
     Time.timeScale = 1.0f;
    }

     public void restart()
  {
    if(Time.timeScale == 0f)
    {
      GameManager.Restart();
      Time.timeScale = 1.0f;
      Physics2D.IgnoreLayerCollision(3,6,false);
    }
  }
}
