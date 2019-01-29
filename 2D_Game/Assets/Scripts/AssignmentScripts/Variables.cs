using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variables : MonoBehaviour {

    public int number;
    public float speed;
    public string name;

	void Start () {
        // This is the syntax for a comment.

        number = 10;
        speed = 0.94f;
        name = "Zach";

		/* 
         
         check
         out
         this
         info
     
          */
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = new Vector3(number, 0, 0);
	}
}
