using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conditionals : MonoBehaviour {

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


