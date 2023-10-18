using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class throwinput : MonoBehaviour
{
   Rigidbody2D rb;
        void Awake(){
            rb = GetComponent<Rigidbody2D>();
        }
       void Update(){
         
             //rb.velocity = new Vector3(5,0,0);
        }
         
}
