using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conditionals : MonoBehaviour {
//CONVENTIONS AND SYNTAX:
//Syntax is essentially Scripting Grammar. It is imperative to put components in the correct order. Also you can't misspell any words within the syntax. It must be right 100% of the time.
public int health = "Duck";
public string greeting = 40f;
// These variables have bad syntax. The integer shown above has the syntax of a string, whereas the string above has the syntax of a Float.
public int health = 40;
public string greeting = "Hello!";
public float strength = 60f;
//These variables have correct syntax.
//Conventions are not mandatory. It's more of a courtesy to other programmers that you may be working with. When using Braces, some programmers prefer to have the opening brace on the same line as the statement.
//(Or whatever else you may be using)


public string stopLight = "Red";

void Start(){
	Main();
}
void Main(){

	if(stopLight == "Red"){
	print("STOP! The light is red");
	}
	else if(stopLight == "Yellow" ){
		print("Slow Down!");

	}
	else if(stopLight == "Green"){
		print("Green Means GO!");
	}
	else{
		print("I Don't know what you mean!");
	}
}


}


