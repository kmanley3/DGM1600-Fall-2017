using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switches : MonoBehaviour {
	public string townCenter;
	public string theDaedalus;


	// Use this for initialization
	void Start () {
		switch(townCenter){
			case "main":
				print("Welcome to Main Street!");
			break;
			case "blacksmith":
				print("The Blacksmith grumbles as you pick through the sword bin.");
			break;
			case "bakery":
				print("Mmmm... Baked goodness!");
			break;
			case "morgue":
				print("Welcome to the house of the dead :D");
			break;
			default:
				print("I don't know what you're talking about!");
			break;
		}
		
		switch(theDaedalus){
			case "chandra":
				print("Can I help you?");
			break;
			case "xander":
				print("I'm a little busy right now, but what do you need?");
			break;
			default:
				print("That person is not on the ship.");
			break;
		} 
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
