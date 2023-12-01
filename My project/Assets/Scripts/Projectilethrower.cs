using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectilethrower : MonoBehaviour
{
    public GameObject knifethrown;
   
    List<GameObject> pool;
    List<GameObject> pool1;

    void Start(){
        pool = new List<GameObject>();
        pool1 = new List<GameObject>();
    }
  

    public void Throw(){
         GameObject knife;
         if(pool.Count > 10){
            pool.RemoveAt(0);
            knife = pool[0];
            knife.transform.position = transform.position;
            //Debug.Log("Work");
         }
         else{
            knife = Instantiate(knifethrown,transform.position,Quaternion.identity);
         }
        pool.Add(knife);
        knife.GetComponent<Rigidbody2D>().velocity = new Vector3(10,4,0);
    }
  public void Throw2(){
        GameObject knife;
         if(pool1.Count > 10){
            pool1.RemoveAt(0);
            knife = pool1[0];
            knife.transform.position = transform.position;
           // Debug.Log("Work");
         }
         else{
            knife = Instantiate(knifethrown,transform.position,Quaternion.identity);
         }
        pool1.Add(knife);
        knife.GetComponent<Rigidbody2D>().velocity = new Vector3(-10,4,0);
    }
    
}

