using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    public void OnTriggerEnter2D (Collider2D other){
       // Debug.Log("Hello");
         if(other.gameObject.tag == "knife"){
            Destroy(this.gameObject);
            PointText.instance.AddPoint();
         }
         
       
        
    }
}
