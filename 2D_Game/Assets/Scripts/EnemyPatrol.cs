using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPatrol : MonoBehaviour {

    //Movement Variables
    public float moveSpeed;
    private bool moveRight;

    //Wall Check
    public Transform wallCheck;
    public float wallCheckRadius;
    public LayerMask whatIsWall;
    private bool hittingWall;

    public float lockPos = 0;

    //Edge Check
    private bool notAtEdge;
    public Transform edgeCheck;

    //Chase Player
    private Transform target;

    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        //Wall and Edgechecks
        notAtEdge = Physics2D.OverlapCircle(edgeCheck.position, wallCheckRadius, whatIsWall);
        hittingWall = Physics2D.OverlapCircle(wallCheck.position, wallCheckRadius, whatIsWall);

    }
    private void FixedUpdate()
    {
        if(GetComponent<Rigidbody2D>().velocity.x > 0 && !moveRight)
        {
            
            GetComponent<Rigidbody2D>().velocity = new Vector2(-moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
        }
        else if (GetComponent<Rigidbody2D>().velocity.x > 0)
        {
            transform.Rotate(0f, 180f, 0f);
            GetComponent<Rigidbody2D>().velocity = new Vector2(moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
        }
    }
    //Update is called once per frame
    void Update () {
        //Check direction of sprite
        transform.Translate(Vector2.right * moveSpeed * Time.deltaTime);
        if(Vector2.Distance(transform.position, target.position) < 8)
        {
            transform.position = Vector2.MoveTowards(transform.position, target.position, moveSpeed * Time.deltaTime);
        }

        if (hittingWall)
        {
            moveRight = !moveRight;
            
        }


        //transform.Translate(Vector2.right * moveSpeed * Time.deltaTime);




        /* if(hittingWall || !notAtEdge)
        {
            moveRight = false;
            Rotate();
            //transform.eulerAngles = new Vector3(0, -180, 0);
        }

        /*if (moveRight)
        {                                     //vvv This is x. These 3 values match the scale of your character
            
            transform.Rotate(0f, 180f, 0f);
            GetComponent<Rigidbody2D>().velocity = new Vector2(moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
        }

        else
        {                                    // See comment above
            //transform.localScale = new Vector3(0.32f, 0.27f, 1f);
            transform.Rotate(0f, 180f, 0f);
            GetComponent<Rigidbody2D>().velocity = new Vector2(-moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
            moveRight = true;
        }*/

    }
}
