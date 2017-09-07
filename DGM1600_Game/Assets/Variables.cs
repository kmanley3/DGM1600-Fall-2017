using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour {

	public float bottledWater = .05f;
//This variable is public! That means everyone can see it. Also, it is a float, which means it's
//a floating integer. It's a decimal number! I just have to make sure that there is an "f" afterward.
	private string waterBottle = "Full";
//The string says the state that the variable is in. Put it in quotations! 
	public int floaties = 1000;
//This type of variable is an integer. It can't have a decimal or it won't work!
	public string floatingFloaties = "Floating";
//This string's access modifier is public! That means you can see it outside of the editor.
	private string sunkFloaties = "Sunk";
//This string's access modiefier is private. That means no one can see it unless they're in the editor.

// string message = "Help Me!";

// 	// Use this for initialization
// 	void Start () {
// 		print("Hello World!");
// 	}
	
// 	// Update is called once per frame
// 	void Update () {
// 		print(message);
// 	}
}
