using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : MonoBehaviour
{
     public void OnTriggerEnter2D (Collider2D other){
       // Debug.Log("Hello");
         if(other.gameObject.tag == "Player"){
            Destroy(this.gameObject);
            PointText.instance.AddPoints();
         }
         
       
        
    }
}
