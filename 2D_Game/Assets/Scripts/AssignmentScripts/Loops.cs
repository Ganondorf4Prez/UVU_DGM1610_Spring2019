using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loops : MonoBehaviour {
    public int bottles = 0;
    int count = 0;

	void Start () {

        //For Loops
        for(int i = 100; i > bottles; --i)
        {
            print(i + " bottles of Apple-Beer on the wall");
            
        }
        for(int x = 1; x < 11; x++)
        {
            print("Let's count up to 10");
            print(x);
        }
        for (int j = 10; count <= j; count++){
            print(count);
        }

        //While Loops
        while(bottles <= 100)
        {
            print(bottles + " bottles of Apple-Beer on the wall");
            bottles++;
        }
        count = 0;
        while(count != 10)
        {
            
            count++;
        }


	}

}
