using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody rbPlayer;
    [SerializeField] private float forwardForce = 100.0f;
    [SerializeField] private float sidewaysForce = 30.0f;

    void FixedUpdate() // est appelé 50x par seconde
    {
        if (Input.GetKey(KeyCode.D))
        {
            rbPlayer.AddForce(sidewaysForce, 0.0f, 0.0f, ForceMode.VelocityChange);
        }
        if (Input.GetKey(KeyCode.Q))
        {
            rbPlayer.AddForce(-sidewaysForce, 0.0f, 0.0f, ForceMode.VelocityChange);
        }
        rbPlayer.AddForce(0.0f, 0.0f, forwardForce); // Ajoute une force au joueur

        if (rbPlayer.position.y < 0)
        {
            FindFirstObjectByType<GameManager>().EndGame();
        }
    }
}
