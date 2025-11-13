using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private bool hasEnded = false;
    [SerializeField] private float restartDelay = 1.0f;
    
    public void EndGame()
    {
        if (hasEnded == false)
        {
            hasEnded = true;
            Debug.Log("Game over !");
            Invoke("Restart", restartDelay);
        }
    }

    private void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
