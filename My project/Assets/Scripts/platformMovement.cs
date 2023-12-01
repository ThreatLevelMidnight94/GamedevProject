using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformMovement : MonoBehaviour
{
    [SerializeField] Transform posA, posB;
    [SerializeField] int speed;
    [SerializeField] GameObject player;
    Vector2 targetPOS;
    
    void Start()
    {
        targetPOS = posA.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector2.Distance(transform.position, posA.position) < .1f){
            targetPOS= posB.position;
        }
         if (Vector2.Distance(transform.position, posB.position) < .1f){
            targetPOS= posA.position;
        }
        transform.position = Vector2.MoveTowards(transform.position, targetPOS, speed * Time.deltaTime);
    }
    private void OnCollisionEnter2D(Collision2D other){
        
         //  other.gameObject.transform.SetParent(gameObject.transform,true);
         other.transform.parent=transform;
       
    }
     private void OnCollisionExit2D(Collision2D collison){
        
            collison.gameObject.transform.parent = null;
        
    }
}
