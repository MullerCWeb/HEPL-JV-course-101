using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private bool hasEnded = false;
    [SerializeField] private float restartDelay = 1.0f;
    [SerializeField] private GameObject completeLevelPanel;
    
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

    public void CompleteLevel()
    {
        Debug.Log("On est dans la zone");
        completeLevelPanel.SetActive(true);
    }
}
