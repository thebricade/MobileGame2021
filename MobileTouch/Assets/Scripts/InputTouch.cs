using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;

public class InputTouch : MonoBehaviour
{
    private Vector3 startPos;
    private Vector3 touchPosition; 
    private Vector3 direction;
    private Vector2 touchPos; 

    public float speed;
    private Rigidbody2D rb2d; 
    
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>(); 
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Moved)
            {
               //Vector3 vec = Camera.main.ScreenToWorldPoint(new Vector3(touch))
               Debug.Log("moving");
               touchPosition = Camera.main.ScreenToWorldPoint(new Vector3(touch.position.x,touch.position.y,Camera.main.nearClipPlane +10f)); //(0,1,0) 
               Debug.Log("touchPosition = " + touchPosition.ToString());
                direction = (touchPosition - transform.position).normalized; 
                rb2d.velocity = direction * speed; 

            }
        }
        
    }
}
