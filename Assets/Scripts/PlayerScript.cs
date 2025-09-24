using UnityEngine;

public class PlayerScript : MonoBehaviour
{ 
    public Rigidbody2D RB;
    public float speed = 5f;
    public Animator animator;

    void Start()
    {
        RB = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        // HORIZONTAL + VERTICAL MOVEMENT
        Vector2 vel = new Vector2(0, 0);

        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
            vel.x = speed;

        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
            vel.x = -speed;

        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
            vel.y = speed;

        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
            vel.y = -speed;

        // Normalize for consistent diagonal speed
        vel = vel.normalized;

        // Apply movement using up-to-date API
        RB.linearVelocity = vel * speed;

        // ANIMATOR HANDLING
        if (vel != Vector2.zero)
        {
            animator.SetBool("isWalking", true);
            animator.SetFloat("InputX", vel.x);
            animator.SetFloat("InputY", vel.y);

            // Update last input only when moving
            animator.SetFloat("LastInputX", vel.x);
            animator.SetFloat("LastInputY", vel.y);
        }
        else
        {
            animator.SetBool("isWalking", false);
            // Leave LastInputX/Y unchanged so player keeps facing last direction
        }
    }
}
