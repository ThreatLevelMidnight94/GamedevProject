using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Life : MonoBehaviour
{   int hitPoint = 1;
    public void OnTriggerEnter2D (Collider2D other){
       // Debug.Log("Hello");
         if(other.gameObject.tag == "Player"){
            Destroy(this.gameObject);
            
            other.GetComponent<Character>().Recover(hitPoint);
         }
}
}
