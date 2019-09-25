using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject levelCompleteUI;
    public float restartDelay = 1f;
    bool gameHasEnded = false;
    // Start is called before the first frame update
    public void CompleteLevel()
    {
        Debug.Log("Level completed!");
        levelCompleteUI.SetActive(true);
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
