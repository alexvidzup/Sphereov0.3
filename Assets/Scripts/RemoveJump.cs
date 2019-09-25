using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveJump : MonoBehaviour
{
    
    public PlayerMovement playerMovement;
    public GameObject player;
    public float playerMass = 5f;
    public float editJumpForce = 0.1f;
    
     void OnTriggerEnter()
     {
         player.GetComponent<PlayerMovement>().jumpForce = editJumpForce;
         player.GetComponent<Rigidbody>().mass = playerMass;
     }
        
    
}
