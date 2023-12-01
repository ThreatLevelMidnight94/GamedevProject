using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleAI : MonoBehaviour
{
    [SerializeField] float radius = 3f;
    [SerializeField] bool activate = false;
    [SerializeField] Transform playerTransform;
    movementZ movement;
    void Awake(){
        movement = GetComponent<movementZ>();
    }

    void Update(){
        if (Vector3.Distance(transform.position, playerTransform.position) < radius){
            FollowPlayer();
        }
        else if(activate){
            Patrol();
        }else{
            Idle();
        }
    }

    public void FollowPlayer(){
        activate = true;
        movement.MoveToward(playerTransform.position);
    }

    Vector3 patrolPos = Vector3.zero;

    public void Patrol(){
        if(Vector3.Distance(transform.position,patrolPos) < 1) {
            patrolPos = transform.position + new Vector3(Random.Range(-3,3),0,0);
        }
        movement.MoveToward(patrolPos);
    }

    public void Idle(){
       if (movement != null){
        movement.Move(Vector3.zero);
    }
    else{
        Debug.LogError("movement is null in Idle method.");
    }
    }
}
