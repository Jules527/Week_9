using UnityEngine;
using UnityEngine.InputSystem;

public class player_controller : MonoBehaviour
{
    public InputActionReference move;
    private Vector2 movevector;
    public Rigidbody2D rb;
    void Start()
    {
        
    }

    void Update()
    {
        movevector = move.action.ReadValue<Vector2>();
        rb.AddForce(movevector * 10);
    }
}
