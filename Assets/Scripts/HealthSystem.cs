using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthSystem : MonoBehaviour
{
    public static int lives = 3;

    public Image[] Hearts ;
    public Sprite fullHeart;
    public Sprite emptyHeart;

    void Awake()
    {
      lives = 3;
    }
    void Update()
    {
      foreach (Image img in Hearts)
     {
      img.sprite = emptyHeart;
     }

      for( int i = 0; i < lives; i++)
      {
        if( i < Hearts.Length)
        {
           Hearts[i].sprite = fullHeart;
        }
      }
    }
}
