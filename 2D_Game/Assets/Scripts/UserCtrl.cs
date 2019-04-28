using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserCtrl : MonoBehaviour {

    //Player movement variables
    public float userSpeed;
    public float jumpHeight;
    public int userHealth = 10;
    

    //Grounded modifiers
    private bool grounded;
    public Transform groundCheck;
    public float groundCheckRadius;
    public LayerMask whatIsGround;

    public Animator animator;


    void Start() {
        //Animation reset
        //animator.SetBool("isWalking", false);
        //animator.SetBool("isJumping", false);

    }
    private void FixedUpdate()
    {
        grounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatIsGround);
    }

    void Update() {
        //Moves player left and right
        if (Input.GetKey(KeyCode.D))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(userSpeed, GetComponent<Rigidbody2D>().velocity.y);
            //animator.SetBool("isWalking", true);
        }
        else if (Input.GetKeyUp(KeyCode.D))
        {
            //animator.SetBool("isWalking", false);
        }

        if (Input.GetKey(KeyCode.A))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(-userSpeed, GetComponent<Rigidbody2D>().velocity.y);
            //animator.SetBool("isWalking", true);
        }
        else if (Input.GetKeyUp(KeyCode.A))
        {
            //animator.SetBool("isWalking", false);
        }

        if (grounded)
        {
            //animator.SetBool("isJumping", false);
        }

        
        //Jump Mechanics
        if (Input.GetKeyDown(KeyCode.W) && grounded)
        {
            Jump();
        }

        //Player Flip
        if (GetComponent<Rigidbody2D>().velocity.x > 0)
            transform.Rotate(0f, 180f, 0f);
        else if (GetComponent<Rigidbody2D>().velocity.x < 0)
            //transform.localScale = new Vector3(-11f, 11f, 1f);
            transform.Rotate(0f, -180f, 0f);
        

    }
    //Jump Function
    void Jump()
    {

        GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, jumpHeight);
        //animator.SetBool("isJumping", true);

    }


}