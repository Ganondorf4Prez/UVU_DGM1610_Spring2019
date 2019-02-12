using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmorPickup : GenericPickup {

    //trigger is a method that allows colliding objects to pass through one another

    public GameObject PlayerChar;

    void OnTriggerEnter2D(Collider2D other) {

        if(other.name == "PlayerChar")
        {
            //collect helmet pickup
        }
        else
        {
            //not player
        }
    }

    
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
