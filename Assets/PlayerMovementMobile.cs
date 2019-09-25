using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementMobile : MonoBehaviour
{
    // reference to rigidbody in unity
    public Rigidbody rb;


    public float forwardForce = 2000f;
    public float playerMovementForce = 1000f;
    public float breakForce = 500f;
    public float jumpForce = 500f;
    public float boostForce = 500f;

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
        rb.AddForce(0,0,forwardForce * Time.deltaTime);  

        if (Input.GetKey("d") || 
        (Input.GetMouseButton(0) && Input.mousePosition.x > Screen.width*2/3) 
        // iPhone accelerator
        || Input.acceleration.x > 0.1f)
        {
            rb.AddForce(playerMovementForce * Time.deltaTime,0,0, ForceMode.VelocityChange); 
        }
        if (Input.GetKey("a") || 
        (Input.GetMouseButton(0) && Input.mousePosition.x < Screen.width/3) 
        // iPhone accelerator
        || Input.acceleration.x < -0.1f)
        {
            rb.AddForce(-playerMovementForce * Time.deltaTime,0,0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("s"))
        {
            rb.AddForce(0, 0, -breakForce * Time.deltaTime, ForceMode.VelocityChange);
        }
        if (Input.GetKey("space") || (Input.GetMouseButton(0) && 
        Input.mousePosition.x >= Screen.width/3 && Input.mousePosition.x <= Screen.width*2/3))
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
}
