using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Screeninput : MonoBehaviour
{
    Rigidbody2D bird;
     public float tjump;
     Animator ani;


    void Start () 
    {
        bird = GetComponent<Rigidbody2D>();
        ani = GetComponent<Animator>();
    }

    public void touchInput()
    {
        Debug.Log("Function is working");

         //TOUCH
        if (Input.touchCount > 0)
        {
            Debug.Log("Yes touch works");
            bird.AddForce(Vector2.up * tjump, ForceMode2D.Impulse);
        }
    }
}
