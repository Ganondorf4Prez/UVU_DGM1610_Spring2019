using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Functions : MonoBehaviour {

    public string weather;
    public int x;
    public int sum;

    private void Start() {

        Weather(weather);
        
    }

    void Weather(string weatherStatus) {

        if (weatherStatus == "Sunny")
        {

            print("Wow it's kinda bright today, huh?");

        }
        else if (weatherStatus == "Raining")
        {

            print("It is soggy and wet today.");

        }
        else if (weatherStatus == "Windy")
        {

            print("It is rather blustery today.");

        }
        else if (weatherStatus == "Snowing")
        {

            print("It is the best type of weather today.");

        }
        else if (weatherStatus == "Foggy")
        {

            print("Visibility is very poor due to fog");

        }
        else if (weatherStatus == "Clear")
        {

            print("The weather is rather clear today.");

        }
        else {

            print("Looks like there's no weather today, other than " + weatherStatus);

        }
    }
    int SquareNum(int x)
    {
        sum = x * x;
        return sum;
    }
    

}
