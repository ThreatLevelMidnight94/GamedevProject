using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hitBox : MonoBehaviour
{
        [SerializeField] Character cha;
        [SerializeField] int hitPoint = 1;
        
        void OnTriggerEnter2D(Collider2D other){
            Debug.Log("Step1");
            if(other.GetComponent<Character>()== null){
                Debug.Log("Step2");
                return;
                 
            }
            if(other.gameObject.tag == "knife"){
                    return;
            }
           if(other.GetComponent<Character>().Equals("knife")){
                Debug.Log("works");
                return;
                 
            }
            if(other.GetComponent<Character>().team == cha.team){
                 Debug.Log("Step3");
                return;
                
            }
             Debug.Log("Step4");
            other.GetComponent<Character>().Damage(hitPoint);
            
            
        }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
