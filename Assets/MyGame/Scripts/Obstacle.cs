using UnityEngine;

public class Obstacle : MonoBehaviour
{
    private Rigidbody2D rb;
    private float leftBoundary = -15f;
    private float rightBoundary = 15f;
    [SerializeField] private float MoveSpeed;
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        //if obstacle's position x is < -15f it will be destroyed
        if (transform.position.x < leftBoundary)
        {
            Destroy(gameObject);
        }
        //if obstacle's position x is < 15f it will be destroyed
        if (transform.position.x > rightBoundary)
        {
            Destroy(gameObject);
        }
    }
    private void FixedUpdate()
    {
        rb.velocity = Vector2.left * MoveSpeed;
    }
}
