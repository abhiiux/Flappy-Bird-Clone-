using UnityEngine.SceneManagement;
using UnityEngine;

public class Inputs : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
         if (Input.GetMouseButtonDown(0) || Input.GetKeyDown("space") || Input.touchCount > 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

            if(Input.touchCount > 0)
            {
              Touch touch = Input.GetTouch(0);
              if(touch.phase == TouchPhase.Began)
              {
                 Debug.Log("Touch is working");
              }
            }
        }
    }

  
}

