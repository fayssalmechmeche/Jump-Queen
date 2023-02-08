using UnityEngine;

public class FixJump : MonoBehaviour
{
    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Vector2 velocity = rb.velocity;
        velocity.y = 0;
        rb.velocity = velocity;
    }
}




