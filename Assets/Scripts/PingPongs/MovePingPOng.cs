﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MovePingPOng : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(Mathf.PingPong(Time.time*2, 3), transform.position.y, transform.position.z);
    }
}
