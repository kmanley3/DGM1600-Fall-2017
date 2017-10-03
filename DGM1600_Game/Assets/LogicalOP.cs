using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicalOP : MonoBehaviour {
	public string luke = "Jedi";
	public string vader = "Sith";
	public bool leia = true;
	public string darkSide = "Darth Maul";
	public string lightSide = "Obi Wan";
	public int num1 = 10;
	public float num2 = 10.5f;
	public bool fn2187 = true;

	// Use this for initialization
	void Start () {
		if(luke == "Jedi" && vader == "Nanny"){	
			print("Vader's yo nanny");
		}
		else if(luke == "Jawa" && vader == "Sith"){
			print("Utinni!");
		}
		else if(luke == "Jedi" && vader == "Sith"){
			print("Nooo! That's not true.. That's impossible!");
		}
		else{
			print("The End!");
		}
		if(leia){
			print("No, there is another...");
		}
		else if(!leia){
			print("Hurray! Now I can date Luke -- but Han is better.");
		}
		else
			print("Han shot first!");
		if(lightSide == "Obi Wan" || darkSide == "Jar Jar Binks"){
			print("Meesa Evil Sith Lord!");
		}
		else if(lightSide == "Boba Fett" || darkSide == "Darth Maul"){
			print("As you wish, my master.");
		}
		else{
			print("Not the younglings.");
		}
		if(num1 == 10 && num2 == 10.5){
			print("Yes!");
		}
		else if(num1 == 10 && num2 == 10){
			print("Almost!");
		}
		else{
			print("No!");
		}
		if(fn2187){
			print("I'll call you Finn!");
		}
		else if(!fn2187){
			print("It's a stormtrooper!");
		}
		else
			print("The rebels have won!");
	}
	
	//Wow! Logical Operators. It's pretty simple
	//&& means AND. So both conditions have to be true.
	//|| means OR. So only one condition has to be true.
	//if it's a boolean, you can put a ! before it to make it false.
	//Make sure there are two of each of your signs (&& || ==) unless it's a !
	
	// Update is called once per frame
	//void Update () {}
		
	}
