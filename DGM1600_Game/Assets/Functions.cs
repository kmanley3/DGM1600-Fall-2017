using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Functions : MonoBehaviour {

	public void DoStuff(){
		print("I'm doing stuff.");
		int result = AddNumbers(5,11);
		print (result);
		int result2 = SubtractNumbers(29,14);
		print (result2);
	}
	void Start(){
		DoStuff();
	}
	public int AddNumbers(int num1,int num2){

		int result = num1 + num2;

		return result;
	}

	public int SubtractNumbers(int num3,int num4){
		int result2 = num3 - num4;
		return result2;
	}
	private int (int num5, int num6);
		int result3 = num5 % num6;

}
