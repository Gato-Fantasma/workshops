using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PLayer : MonoBehaviour
   
{
    private Rigidbody2D rb;
    private Vector2 move;
    public float speed;
    public float inputX;


    // Start is called before the first frame update
    
    void Start()
    {
        rb=GetComponent<Rigidbody2D>();
      
    }

    // Update is called once per frame
    void Update()
    {    
      InputLogic();
    }

    private void FixedUpdate()
{
    MoveLogic();
}

    public void InputLogic()
    {
     inputX = Input.GetAxisRaw("Horizontal");
    
    }
     public void MoveLogic ()
     { 
        move=new Vector2(inputX*speed,rb.velocity.y);
        rb.velocity=move;
     }
}
