using UnityEngine;

public class PlayerJump2D : MonoBehaviour
{
    public float jumpForce = 5f; // Adjustable force for the jump
    private Rigidbody2D rb;
    private bool isGrounded = true;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); // Get the Rigidbody2D component
        if (rb == null)
        {
            Debug.LogError("Rigidbody2D component missing from this GameObject!");
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            Jump();
        }
    }

    void Jump()
    {
        rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce);
        isGrounded = false; // Prevent double jumps
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Check if the player is touching the ground
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }
}
