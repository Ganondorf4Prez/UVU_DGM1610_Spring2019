using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserCtrl : MonoBehaviour {

    public float userSpeed;


	
	void Start () {
		
	}
	
	
	void Update () {
        if (Input.GetKey(KeyCode.D))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(userSpeed, GetComponent<Rigidbody2D>().velocity.y);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(-userSpeed, GetComponent<Rigidbody2D>().velocity.y);
        }
		
	}
}
