using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public Transform tr;
    public static float speed = 2f;
    // Start is called before the first frame update
    void Awake()
    {
      speed = 2f;
    }
    void Start()
    {
     tr = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
      tr.Translate(Vector2.right * speed * Time.deltaTime);
    }
}
