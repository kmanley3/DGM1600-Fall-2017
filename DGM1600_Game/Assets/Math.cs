using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Math : MonoBehaviour {
public int valueOne;
public int valueTwo;
public int valueThree;
public int valueFour;
private int result;

	// Use this for initialization
	void Start () {
		DoMath();
	}

	void DoMath (){
		result = valueOne + valueTwo;
		print(valueOne + " + " + valueTwo + " = " + result);
	
			//Math operators! In order for them to work, you have to put the result first. 
			//The syntax is wrong if you do it x + y = z. You have to do it z = x + y.
			//There are at least 4 operators: + - * /
			//You do not have to set the value in the editor.You have to set the value in the Inspector in Unity.
			//To get it to print in Unity, you have to MAKE it print by writing a line of code for it. As shown below!
			//For it to print your operators, you have to pretend that they are strings and put them in quotation marks
			//If you want it to print the value that you put in Unity, you do not have to put quotation marks.
			//You can just type it in as normal.

		result = valueOne - valueTwo;
		print(valueOne + " - " + valueTwo + " = " + result);

		result = valueOne * valueTwo;
		print(valueOne + " * " + valueTwo + " = " + result);

		result = valueOne / valueTwo;
		print(valueOne + " / " + valueTwo + " = " + result);

		result = valueThree + valueFour;
		print(valueThree + " + " + valueFour + " = " + result);

		result = valueThree - valueFour;
		print(valueThree + " - " + valueFour + " = " + result);

		result = valueThree * valueFour;
		print(valueThree + " * " + valueFour + " = " + result);

		result = valueThree / valueFour;
		print(valueThree + " / " + valueFour + " = " + result);
		
	}
	// Update is called once per frame
	//void Update () {
		
	//}
}
