using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NGameManager : MonoBehaviour
{
    public float restartDelay = 1f;
    bool gameHasEnded = false;
    // Start is called before the first frame update
    public void CompleteLevel()
    {
        Debug.Log("Level completed!");
    }

    public void EngGame()
    {
        
        if (gameHasEnded == false)
        {
            gameHasEnded = true; 
            Debug.Log("Game Over");
            // restart
            Invoke("Restart", restartDelay);
        }
    }

    void Restart ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
