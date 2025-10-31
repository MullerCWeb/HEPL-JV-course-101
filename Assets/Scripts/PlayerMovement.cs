using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rbPlayer;
    [SerializeField] private float forwardForce = 100.0f;

    void FixedUpdate() // est appelé 50x par seconde
    {
        if (Input.GetKey("d"))
        {
            rbPlayer.AddForce(0.0f, 0.0f, forwardForce); // Ajoute une force au joueur
        }
        
    }
}
