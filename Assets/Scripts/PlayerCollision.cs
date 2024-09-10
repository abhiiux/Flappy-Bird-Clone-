using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerCollision : MonoBehaviour
{
    Rigidbody2D bird;
    public Movebytouch script;
    public Animator ani ;
    public GameObject pausebutton;

 void Start()
 {
    bird = GetComponent<Rigidbody2D>();
 }

    //Detecting collision
      private void OnCollisionEnter2D(Collision2D Col)
    {
        if(Col.gameObject.CompareTag("Obstacle"))
        {
           Debug.Log("Collision detected!");
           HealthSystem.lives--;

         if(HealthSystem.lives <= 0)
         {
           script.enabled = false ;
           ani.enabled = false ;
           Move.leftForce = 0f;
           move.speed = 0f;
            
          GameManager.Endgame();
          pausebutton.SetActive(false);
         }
         else
         {
             StartCoroutine(GetHurt());
         }
        }
        
        }
        IEnumerator GetHurt()
       {
        Physics2D.IgnoreLayerCollision(3,6);
        GetComponent<Animator>().SetLayerWeight(1,1);

        yield return new WaitForSeconds(3);

        GetComponent<Animator>().SetLayerWeight(1,0);
        Physics2D.IgnoreLayerCollision(3,6,false);
       }


}
