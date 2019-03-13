using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserCtrl : MonoBehaviour {

    //Player movement variables
    public float userSpeed;
    public float jumpHeight;

    //Grounded modifiers
    private bool grounded;
    public Transform groundCheck;
    public float groundCheckRadius;
    public LayerMask whatIsGround;

	
	void Start () {
        //Default grounding set
        
	}
    private void FixedUpdate()
    {
        grounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatIsGround);
    }

    void Update () {
        //Moves player left and right
        if (Input.GetKey(KeyCode.D))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(userSpeed, GetComponent<Rigidbody2D>().velocity.y);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(-userSpeed, GetComponent<Rigidbody2D>().velocity.y);
        }
        
        //Jump Mechanics
        if (Input.GetKeyDown(KeyCode.W) && grounded)
        {
            Jump(); 
        }
		
	}
    //Jump Function
    void Jump()
    {

        GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, jumpHeight);

    }


}
