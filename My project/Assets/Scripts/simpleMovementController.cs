using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class simpleMovementController : MonoBehaviour
{
   [SerializeField] Movement movement;
    void Start()
    {
        
    }

    void FixedUpdate(){
        Vector3 vel = Vector3.zero;
        if(Input.GetKey(KeyCode.D)){
            vel.x = 1;
        }
        if(Input.GetKey(KeyCode.A)){
            vel.x = -1;
        }
        movement.Move(vel);
    }
    
}
