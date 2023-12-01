using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movementZ : MonoBehaviour
{
    Rigidbody2D rb;
   [SerializeField] float speed = 5;
   [SerializeField] float jumpForce =5;
   [SerializeField] LayerMask groundMask;
   
   void Awake(){
      rb = GetComponent<Rigidbody2D>();
      
   }
   public void Move (Vector3 mov){
    mov *= speed;
    mov.y = rb.velocity.y;
    rb.velocity = mov;
   
   }
   public void Stop(){
         rb.velocity = new Vector3(0, rb.velocity.y, 0);
   }

   public void Jump(){
    if(Physics2D.OverlapCircleAll(transform.position - new Vector3(0,.5f,0),.25f,groundMask).Length > 0){
        rb.AddForce(new Vector3(0,jumpForce,0), ForceMode2D.Impulse);
    }
    
   }
   public void MoveToward(Vector3 targetPosition){
        Vector3 direction = targetPosition - transform.position;
        direction = Vector3.Normalize(direction);
        Move(direction);
    }
}