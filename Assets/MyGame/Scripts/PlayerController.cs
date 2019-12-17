using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // init variables
    private Rigidbody2D rb;
    private Animator anim;
    private bool grounded;
    private bool gameOver = false;
    private string triggerJump = "Jump";
    private string groundTag = "Ground";
    private string obstacleTag = "Obstacle";
    private string animDeath = "SantaDeath";
    [SerializeField] private float jumpForce;
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }
    // Update is called once per frame
    private void Update()
    {
        if (Input.GetMouseButton(0) && !gameOver && !gameOver && !gameOver)
        {
            if (grounded == true)
            {
                Jump();
            }
        }
    }
    private void Jump()
    {
        grounded = false;
        rb.velocity = Vector2.up * jumpForce;
        anim.SetTrigger(triggerJump);
        GameManager.instance.IncrementScore();
        Debug.Log("DeleteMe");
    }
    private bool SetGameOverTrue()
    {
        return true;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == groundTag)
        {
            grounded = true;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == obstacleTag)
        {
            GameManager.instance.GameOver();
            Destroy(collision.gameObject);
            anim.Play(animDeath);
            gameOver = SetGameOverTrue();
        }
    }
}
