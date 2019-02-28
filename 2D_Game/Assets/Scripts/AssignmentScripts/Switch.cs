using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour {

    public string suspect;
    public string weapon;
    public string room;


	void Start () {
        MurderMystery(suspect);
	}
	void Update () {
	}
    void MurderMystery(string person)
    {
        switch (person)
        {
            case "Mr. Ketchup":
            case "Colonel Mustard":
                print("I was in the billiard room smoking a cigar and playing...cut throat...");
                break;
            case "Ms. Frysauce":
                print("I was talking on the rotory phone with my mother, Mrs. Mayo");
                break;
            case "Mrs. Mayo":
                print("I was in the kitchen cleaning up the dishes with the scrubber");
                break;
            default:
                print("I am not familiar with " + person + "!");
                break;
        }
    }

}

