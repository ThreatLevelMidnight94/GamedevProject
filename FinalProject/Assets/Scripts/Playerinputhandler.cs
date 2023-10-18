using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playerinputhandler : MonoBehaviour
{
   
    [SerializeField] GameObject knife;
    [SerializeField] Soldier pc;
    
    void Awake(){
      
    }
    
    void Update()
    {  
         if(Input.GetKey(KeyCode.D)){
            pc.Move(new Vector3(1,0,0));
        }

        else if(Input.GetKey(KeyCode.A)){
            pc.Move(new Vector3(-1,0,0));
        }
        else {
            pc.Stop();
        }
           if (Input.GetKeyDown(KeyCode.Space)){
            pc.Jump();
        }
    
        
    }
    
}
