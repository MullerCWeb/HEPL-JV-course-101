using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider colliderInfo)
    {
        FindFirstObjectByType<GameManager>().CompleteLevel();
    }
}
