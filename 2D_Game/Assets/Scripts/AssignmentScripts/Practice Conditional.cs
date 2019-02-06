using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PracticeConditional : MonoBehaviour {

    public string food;

	// Use this for initialization
	private void Start () {

        MealChoice(food);
		
	}
	
	// Update is called once per frame
	void MealChoice(string meal) {

        print("What would you like for lunch?");

        if(meal == "Pizza")
        {
            print("Pizza pizza!");
        }
		else if(meal == "Burger")
        {
            print("Yeah that sounds good!");
        }
        else if(meal == "Panda")
        {
            print("Ooooh, I could go for Panda!");
        }
        else if(meal == "Salad")
        {
            print("Well that's kinda lightweight!");
        }
        else if(meal == "Costa")
        {
            print("Yep that's what I'm having too!");

        }
        else if(meal == "Costa Vida")
        {
            print("Yep that's what I'm having too!");
        }
        else
        {
            print("I'm not sure what you would like for lunch... what exactly is " + meal + "?");
        }
	}
}
