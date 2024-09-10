using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public Transform tr;
    public static float leftForce = 2f ;

    void Awake()
    {
      leftForce = 2f;
    }

    // Start is called before the first frame update
    void Start()
    {
        tr = GetComponent<Transform>();
    }
    void Update()
    {
      tr.Translate(Vector2.left * leftForce * Time.deltaTime);
    }
    
}
