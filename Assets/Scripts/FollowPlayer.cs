using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{

    public Transform player;
    public Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //prints out player position to the console
        //Debug.Log(player.position);
       // change position of the 'transform' parameter 
       //of the current object (object that script is applied to)
       // to position of the player object
        transform.position = player.position + offset;
    }
}
