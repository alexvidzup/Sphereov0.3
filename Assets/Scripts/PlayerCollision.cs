using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;
    
    void OnCollisionEnter (Collision collisionInfo)
    {

        // if (collisionInfo.GetComponent<Collider>().tag == "Obstacle")

        // {

        //     movement.enabled = false;

        //     FindObjectOfType<GameManager>().EngGame(); 
        // }
        // if (collisionInfo.GetComponent<Collider>().tag
        //     == "Obstacle")
        // {
        //    movement.enabled = false;

        //     FindObjectOfType<GameManager>().EngGame(); 
        
        
    }
    
}
