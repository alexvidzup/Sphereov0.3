using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateLine : MonoBehaviour
{
    public GameObject pressWForBoost;
    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        pressWForBoost.SetActive(true);
    }
}
