using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
   Rigidbody2D rb;
   [SerializeField] float speed = 5;
   void Awake(){
      rb = GetComponent<Rigidbody2D>();
   }
   public void Move (Vector3 mov){
    rb.velocity = (mov * speed);
   }
   public void Stop(){
         rb.velocity = new Vector3(0, rb.velocity, 0);
   }
  
}
