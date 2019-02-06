using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PracticeVariableWork : MonoBehaviour {

    //Function SquareNum simply squares a number.
    public int num;
    public int total;

	private void Start() {

        SquareNum(num);

	}

	void SquareNum(int number) {
        number = number * number;
		
	}
}
