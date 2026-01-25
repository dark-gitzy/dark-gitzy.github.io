using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public float jumpForce = 6f;
    private Rigidbody2D rb;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (
            Input.GetKeyDown(KeyCode.space) ||
            Input.GetMouseButton(0) ||
            (Input.GetTouch > 0 &&
            Input.GetTouch(0).phase ==
            TouchPhase.Began)
        )
        {
            Jump();
        }
    }

    void Jump()
    {
        rb.linearVelocity = Vector2.zero;
        rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
    }
}
