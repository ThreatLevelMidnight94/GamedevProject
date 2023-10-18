using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectilethrower : MonoBehaviour
{
    public GameObject knifethrown;
   

    public void Throw(){
         GameObject knife;
        knife = Instantiate(knifethrown,transform.position,Quaternion.identity);
        knife.GetComponent<Rigidbody2D>().velocity = new Vector3(10,4,0);
    }
  public void Throw2(){
         GameObject knife;
        knife = Instantiate(knifethrown,transform.position,Quaternion.identity);
        knife.GetComponent<Rigidbody2D>().velocity = new Vector3(-10,4,0);
    }
    
}

