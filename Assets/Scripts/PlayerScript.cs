using UnityEngine;

public class PlayerScript : MonoBehaviour
{ 
    public Rigidbody2D RB; 
    public float speed = 5f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        RB = GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame
    void Update()
    {
       //HORIZONTAL MOVEMENT 
        Vector2 vel = new Vector2(0,0);
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            vel.x= speed; //MOVE RIGHT
        }
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            vel.x = -speed; //MOVE LEFT
        }
        
        //VERTICAL MOVEMENT
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {
            vel.y = speed; // MOVE UP
        }
        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {
            vel.y = -speed; // MOVE DOWN
        }
        RB.linearVelocity = vel;

    }
    
}
