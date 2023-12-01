using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
        [SerializeField] GameObject knife;
        [SerializeField] Movement pc;
        [SerializeField] Projectilethrower projectile;
        [SerializeField] Transform body;
                        int num = 0;
        void Awake(){
            
        }

        void Update()
        {  
           if(Input.GetKey(KeyCode.D)){
            body.localScale= new Vector3 (1,1,1);
            pc.Move(new Vector3(1,0,0));
            num = 0;
            }
       
        else if(Input.GetKey(KeyCode.A)){
            body.localScale= new Vector3 (-1,1,1);
            pc.Move(new Vector3(-1,0,0)); 
            num = 1;   
        }
        else {
            pc.Stop();
        }
            if (Input.GetKeyDown(KeyCode.Space)){
            pc.Jump();
        }
           
             if(Input.GetKeyDown(KeyCode.F)){
                if (num == 0){
                    GetComponent<AudioSource>().Play();
                    projectile.Throw(); 
                    }
                if (num == 1){
                   GetComponent<AudioSource>().Play();
                    projectile.Throw2();
                    
                }
            }


        }
}
