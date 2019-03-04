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
    void StopLight(string light)
    {
        switch (light)
        {
            case "Red":
            case "Flashing Red":
                print("The light designates a stop");
                break;
            case "Yellow":
                print("The light designates slowing down");
                break;
            case "Green":
                print("The light designates passing freely");
                break;
            default:
                print("The light color, " + light + "is unknown");
                break;

        }
    }
    void Weather(string outside)
    {
        switch (outside)
        {
            case "Snowy":
                print("Enjoy the weather outside!");
                break;
            case "Windy":
                print("May need a jumper!");
                break;
            case "Sunny":
                print("Avoid the cancer out there...");
                break;
            case "Cloudy":
                print("Nice on the eyes today");
                break;
            default:
                print("The weather outside is " + outside);
                break;

        }
    }
    void Switches(string swap)
    {
        switch (swap)
        {
            case "Swich":
            case "Switched":
            case "Switches":
            case "Switching":
                print("Switched");
                break;
            default:
                print("Left unswitched");
                break;
            
        }
    }
}   


