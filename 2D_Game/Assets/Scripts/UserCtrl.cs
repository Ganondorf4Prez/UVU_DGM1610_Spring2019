using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class UserCtrl : MonoBehaviour {

    //Player movement variables
    public float userSpeed;
    public float jumpHeight;
    public int userHealth = 10;
    public bool faceRight = true;

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

        //animator.SetFloat("Speed", Mathf.Abs(userSpeed));
        if (Input.GetKey(KeyCode.D))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(userSpeed, GetComponent<Rigidbody2D>().velocity.y);
            animator.SetBool("isWalking", true);
        }
        else if (Input.GetKeyUp(KeyCode.D))
        {
            animator.SetBool("isWalking", false);

        }

        if (Input.GetKey(KeyCode.A))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(-userSpeed, GetComponent<Rigidbody2D>().velocity.y);
            animator.SetBool("isWalking", true);

        }
        else if (Input.GetKeyUp(KeyCode.A))
        {
            animator.SetBool("isWalking", false);
        }
        if (grounded)
        {
            animator.SetBool("isJumping", false);
        }
        //Jump Mechanics
        if (Input.GetKeyDown(KeyCode.W) && grounded)
        {
            Jump();
        }

        //Player Flip
        
        if (GetComponent<Rigidbody2D>().velocity.x > 0 && !faceRight)
        {
            Flip();
        }
        else if (GetComponent<Rigidbody2D>().velocity.x < 0 && faceRight)
        {
            Flip();
        }
            



    }
    void Flip()
    {
        faceRight = !faceRight;

        transform.Rotate(0f, 180f, 0f);
        /*Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;*/
    }
    //Jump Function
    void Jump()
    {

        GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, jumpHeight);
        animator.SetBool("isJumping", true);

    }


}

    
    
        
    


