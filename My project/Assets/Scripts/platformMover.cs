using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class StickyPlatform : MonoBehaviour

{



private Rigidbody2D platformRb;

private Rigidbody2D playerRb;
[SerializeField] Transform posA, posB;
    [SerializeField] int speed;
    [SerializeField] GameObject player;
    Vector2 targetPOS;
    void Start()
    {
        targetPOS = posA.position;
    }

    // Update is called once per frame
   


private void Awake()

{

platformRb = GetComponent<Rigidbody2D>();

playerRb = GameObject.FindGameObjectWithTag("Player").GetComponent<Rigidbody2D>();

}

private void Update()

{
    
        if (Vector2.Distance(transform.position, posA.position) < .1f){
            targetPOS= posB.position;
        }
         if (Vector2.Distance(transform.position, posB.position) < .1f){
            targetPOS= posA.position;
        }
      
transform.position = Vector2.MoveTowards(transform.position, targetPOS, speed * Time.deltaTime);
platformRb.velocity = platformRb.velocity;

playerRb.velocity = new Vector2(playerRb.velocity.x + platformRb.velocity.x, playerRb.velocity.y + platformRb.velocity.y);

}

private void OnTriggerEnter2D(Collider2D collision)

{

if (collision.gameObject.CompareTag("Player"))

{

player = collision.gameObject;

player.transform.SetParent(transform);


}

}

private void OnTriggerExit2D(Collider2D collision)

{

if (collision.gameObject.CompareTag("Player"))

{

player.transform.SetParent(null);

}

}

}