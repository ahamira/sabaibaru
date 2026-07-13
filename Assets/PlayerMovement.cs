using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;

    Rigidbody2D rb;
    Vector2 moveInput;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        moveInput = Vector2.zero;

        if (Keyboard.current.wKey.isPressed)
        {
            moveInput.y += 1;
        }

        if (Keyboard.current.sKey.isPressed)
        {
            moveInput.y -= 1;
        }

        if (Keyboard.current.aKey.isPressed)
        {
            moveInput.x -= 1;
        }

        if (Keyboard.current.dKey.isPressed)
        {
            moveInput.x += 1;
        }
    }

    void FixedUpdate()
    {
        rb.linearVelocity = moveInput.normalized * speed;
    }
}