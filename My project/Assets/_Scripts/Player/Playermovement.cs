using UnityEngine;
using UnityEngine.InputSystem;
public class Playermovement : MonoBehaviour
{
    private float movementSpeed = 5f;

    private Rigidbody2D rb;
   
    float horizontalMovement;
    float verticalMovement;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    [System.Obsolete]
    void Update()
    {
       rb.velocity = new Vector2(horizontalMovement * movementSpeed,rb.velocity.y);
        rb.velocity = new Vector2(verticalMovement * movementSpeed, rb.velocity.x);

    }

    public void Move(InputAction.CallbackContext context)
    {
        horizontalMovement = context.ReadValue<Vector2>().y;
        verticalMovement = context.ReadValue<Vector2>().x;
    }
}
