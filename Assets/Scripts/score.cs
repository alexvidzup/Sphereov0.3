using System;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    public Transform player;
    public Text scoreText;

    void Start()
    {
        // // DOES NOT WORK
        Invoke("ChangeText", 2f);
        //System.Threading.Thread.Sleep(1500);
        //scoreText.text = "Survive as long as possible!";
        //System.Threading.Thread.Sleep(1500);
    }
    public void ChangeText()
    {
        scoreText.text = "Survive as long as possible!";
    }
    // Update is called once per frame
    void Update()
    {
        scoreText.text = player.position.z.ToString("0");
    }
}
