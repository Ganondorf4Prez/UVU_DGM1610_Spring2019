using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class If_Statements : MonoBehaviour {

    public string stoplight;
    public bool isUtahn = true;


    public int speed;              //Variable for homework conditional  1
    public int speedLimit = 65;   //Variable for homework conditional  1
    public bool inCar = true;    //Variable for homework conditional  1

    public int x;                //Variable for homework conditional 2

    public string fruit;        //Variable for homework conditional 3
    public bool isFruit;        //Variable for homework conditional 3

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
        if (stoplight == "Red")
        {
            if(isUtahn)
            {
                print("Stop! The light is red!");
            }
            else
            {
                print("Thank you for stopping at the light!");
            }
        }
        else if(stoplight == "Yellow")
        {
            if (isUtahn)
            {
                print("Shoot the gap, you can make it");
            }
            else
            {
                print("Thank you for preparing to stop");
            }
        }
        else if(stoplight == "Green")
        {
            if (isUtahn)
            {
                print("Either continue or turn right without signaling");
            }
            else
            {
                print("THank you for properly accelerating on a green light!");
            }
        }
        else
        {
            if (isUtahn)
            {
                print("I'm not sure what the light is, and neither are you");
            }
            print("Hmm sorry, you are driving in Utah!");
        }


        // Conditional 1 for homework
        if(speed == speedLimit)
        {
            print("You are going the limit (but thin ice, buddy)");
        }
        else if(speed < speedLimit)
        {
            print("You are going below the limit");
        }
        else if(speed > speedLimit)
        {
            if (inCar)
            { 
                print("WOAH! You are SPEEDING!");
            }
            else
            {
                print("Ah, you must be in a plane. Nice speed!");
            }
        }


        // Conditional 2 for homework
        if(x < 0)
        {
            print("The number is negative");
        }
        else if (x == 0)
        {
            print("The number is equal to zero");
        }
        else if (x > 0)
        {
            print("The number is greater than zero");
        }





        // Conditional 3 for homework
        if(fruit == "Apple")
        {
            print("One a day and the Doc goes away!");
        }
        else if (fruit == "Banana")
        {
            print("Delicious! Nice and limber!");
        }
        else if(fruit == "Orange")
        {
            print("Just like the color!");
        }
        else
        {
            print("Not sure what that fruit is...");
        }

        if (!isFruit)
        {
            print("Hey, that's not even a fruit!");
        }

	}
}
