using UnityEngine;
using UnityEngine.InputSystem;
public class Playermovement : MonoBehaviour
{
    private float movementSpeed = 5f;

    private Rigidbody2D rb;

    private Vector2 _moveDirection;

    public InputActionReference move;
    public InputActionReference interact; //For dialogue and other options

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    [System.Obsolete]
    void Update()
    {
        _moveDirection = move.action.ReadValue<Vector2>();

    }

    public void FixedUpdate()
    {
        rb.linearVelocity = new Vector2(_moveDirection.x * movementSpeed, _moveDirection.y * movementSpeed);
    }

    private void OnEnable()
    {
        interact.action.started += Interaction;
    }

    private void Interaction(InputAction.CallbackContext obj)
    {
        Debug.Log("Interaction / Action button has been pressed");
    }
}