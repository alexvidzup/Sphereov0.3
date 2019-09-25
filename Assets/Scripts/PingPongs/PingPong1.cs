using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PingPong1 : MonoBehaviour
{
    public float mod1 = 2f;
    public float mod2 = 2f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(Mathf.PingPong(Time.time*mod1, mod2), transform.position.y, transform.position.z);
    }
}
