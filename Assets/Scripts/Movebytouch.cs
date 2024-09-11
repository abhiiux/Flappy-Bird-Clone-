using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Movebytouch : MonoBehaviour
{
    Rigidbody2D bird;
    public float jump;
    Transform tb;
    Animator ani;

    // Start is called before the first frame update
    void Start()
    {
        bird = GetComponent<Rigidbody2D>();
       tb = GetComponent<Transform>();
       ani = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //MOVEMENT
        //Keyboard
        if(Input.GetKeyDown(KeyCode.Space))
            {
              //Debug.Log("space is pressed!");
              bird.AddForce(Vector2.up * jump, ForceMode2D.Impulse);
              tb.Rotate(0,0,20);
              ani.SetBool("isjumping",true);
            }
        if(Input.GetKeyUp(KeyCode.Space))
        {
            tb.Rotate(0,0,-20);
            ani.SetBool("isjumping",false);
        }
                  
    }
}

