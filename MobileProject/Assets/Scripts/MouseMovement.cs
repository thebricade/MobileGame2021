using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseMovement : MonoBehaviour
{
    // Start is called before the first frame update
    private Vector3 touchPosition;
    private Vector3 direction; 
    
    public float speed; //our movement speed, making public so we can edit in inspector
    private Rigidbody2D rb2d; //reference we'll need to use any 2D physics
    
    void Start()
    {
        //getting a reference to rigidbody2D 
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //checking if the mouse is being held down
        // 0 checks left button  (only this will work on mobile) 
        // 1 checks right button
        // 2 checks middle    
        // https://docs.unity3d.com/ScriptReference/Input.GetMouseButton.html
        if (Input.GetMouseButton(0))
        {
           touchPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            touchPosition.z = 0;
          //  touchPosition = Camera.main.ScreenToViewportPoint(Input.mousePosition);
         //   touchPosition.z = 0;
            
            direction = (touchPosition - transform.position).normalized;
            rb2d.velocity = direction * speed; 
            // var worldPos = Camera.main.ScreenToViewportPoint(Input.mousePosition);
        }
        rb2d.AddForce(Vector2.zero);
        
     
    }
}
