using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuadraticCalcTest : MonoBehaviour {

    public int a;
    public int b;
    public int c;
    private int xplus;
    private int xneg;

	private void Start () {

        //The program determines the two roots of quadratic, taking in a, b, c for input
        print("Enter in values for a.");
        print("Enter in values for b.");
        print("Enter in values for c.");

        Quadradify(xplus, xneg);

	}

	void Quadradify(int num1, int num2) {

        xplus = ((-1) * b) + (((b * b) - (4 * a * c)) ^ 1/2);
        xneg = ((-1) * b) - (((b * b) - (4 * a * c)) ^ 1 / 2);

        print("The positive X is " + xplus);
        print("The negative X is " + xneg);
		
	}
}
