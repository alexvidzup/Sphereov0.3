using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{


    // reference to rigidbody in unity
    public Rigidbody rb;


    public float forwardForce = 2000f;
    public float playerMovementForce = 1000f;
    public float breakForce = 500f;
    public float jumpForce = 500f;
    public float boostForce = 500f;
    public GameObject scoreCanvas;
    public GameObject boostButton;

    // Coefficients for iPhone accelerometer
    // forwards and backwards
    public float cN0 = 0.15f;
    public float cN1 = 0.4f;
    public float cN2 = 0.8f;
    public float cN3 = 1.2f;
    public float cN4 = 2.0f;
    //sideways
    public float dN1 = 0.5f;
    public float dN2 = 0.75f;
    public float dN3 = 1f;
    public float dN4 = 1.25f;
    public float dN5 = 1.5f;
    public float dN6 = 1.75f;

    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log("This is a message for Alex");
        //rb.useGravity = false;
        //rb.AddForce(0,200,500);
    }


    // Fixed update because that is what is used to "mess" with physics 
    // Update is called once per frame
    void FixedUpdate()
    {
        // add forward force to the player object
       // rb.AddForce(0,0,forwardForce * Time.deltaTime); 

        //===========TRY ACCELERATION WITH iPhone===================
        // ================= FORWARD AND BACKWARDS================
        // ================= FORWARD AND BACKWARDS================
        // ================= FORWARD AND BACKWARDS================
         if (Input.acceleration.z >= -0.2f)
        {
              rb.AddForce(0,0,-cN0*playerMovementForce * Time.deltaTime, ForceMode.VelocityChange);
        }
        if (Input.acceleration.z <= -0.25f)
        {
             rb.AddForce(0,0,cN1*playerMovementForce * Time.deltaTime, ForceMode.VelocityChange); 
        }
         if (Input.acceleration.z <= -0.5f)
        {
             rb.AddForce(0,0,cN2*playerMovementForce * Time.deltaTime, ForceMode.VelocityChange); 
        }
         if (Input.acceleration.z <= -0.75f)
        {
             rb.AddForce(0,0,cN3*playerMovementForce * Time.deltaTime, ForceMode.VelocityChange); 
        }
         if (Input.acceleration.z <= -0.85f)
        {
             rb.AddForce(0,0,cN4*playerMovementForce * Time.deltaTime, ForceMode.VelocityChange); 
        }

        //==============================SIDEWAYS=================SIDEWAYS=====================
        //============================SIDEWAYS==================SIDEWAYS========================
        //==========================SIDEWAYS===================SIDEWAYS====================

        if (Input.acceleration.x > 0.1f)
        {
            rb.AddForce(dN2*playerMovementForce * Time.deltaTime,0,0, ForceMode.VelocityChange); 
        }
        if (Input.acceleration.x > 0.20f)
        {
            rb.AddForce(dN3*playerMovementForce * Time.deltaTime,0,0, ForceMode.VelocityChange); 
        }
         if (Input.acceleration.x > 0.3f)
        {
            rb.AddForce(dN4*playerMovementForce * Time.deltaTime,0,0, ForceMode.VelocityChange); 
        }

        if (Input.acceleration.x > 0.4f)
        {
            rb.AddForce(dN5*playerMovementForce * Time.deltaTime,0,0, ForceMode.VelocityChange); 
        }
        if (Input.acceleration.x > 0.5f)
        {
            rb.AddForce(dN6*playerMovementForce * Time.deltaTime,0,0, ForceMode.VelocityChange); 
        }
        if (Input.acceleration.x > 0.6f)
        {
            rb.AddForce(dN6*playerMovementForce * Time.deltaTime,0,0, ForceMode.VelocityChange); 
        }
        
        
        
     
        if (Input.acceleration.x < -0.1f)
        {
            rb.AddForce(dN2*(-playerMovementForce) * Time.deltaTime,0,0, ForceMode.VelocityChange);
        }
         if (Input.acceleration.x < -0.20f)
        {
            rb.AddForce(dN3*(-playerMovementForce) * Time.deltaTime,0,0, ForceMode.VelocityChange);
        }
          if (Input.acceleration.x < -0.3f)
        {
            rb.AddForce(dN4*(-playerMovementForce) * Time.deltaTime,0,0, ForceMode.VelocityChange);
        }
         if (Input.acceleration.x < -0.4f)
        {
            rb.AddForce(dN5*(-playerMovementForce) * Time.deltaTime,0,0, ForceMode.VelocityChange);
        }
         if (Input.acceleration.x < -0.5f)
        {
            rb.AddForce(dN6*(-playerMovementForce) * Time.deltaTime,0,0, ForceMode.VelocityChange);
        }
         if (Input.acceleration.x < -0.6f)
        {
            rb.AddForce(dN6*(-playerMovementForce) * Time.deltaTime,0,0, ForceMode.VelocityChange);
        }








        // KEYBOARDS SIDEWAYS
        if (Input.GetKey("d"))
        //(Input.GetMouseButton(0) && Input.mousePosition.x > Screen.width*2/3) || // comment out to disable
        {
            rb.AddForce(playerMovementForce * Time.deltaTime,0,0, ForceMode.VelocityChange); 
        }
        if (Input.GetKey("a"))
        //(Input.GetMouseButton(0) && Input.mousePosition.x < Screen.width/3)  || // comment out to disable
        {
            rb.AddForce(-playerMovementForce * Time.deltaTime,0,0, ForceMode.VelocityChange);
        } 
        

         
        









        if (Input.GetKey("s"))
        {
            rb.AddForce(0, 0, -breakForce * Time.deltaTime, ForceMode.VelocityChange);
        }
        if (Input.GetKey("space") || (Input.GetMouseButton(0) && 
        Input.mousePosition.x >= Screen.width/5 && Input.mousePosition.x <= Screen.width*4/5))
        {
            rb.AddForce(0, jumpForce, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("w"))
        {
            rb.AddForce(0,0,boostForce, ForceMode.VelocityChange);
        }
        if (rb.position.y < -1)
        {
            FindObjectOfType<GameManager>().EngGame();
        }



    }
    public void Boost ()
    {
        rb.AddForce(0,0,200f, ForceMode.VelocityChange);
        Debug.Log("Pressing boost button");
    }
}
