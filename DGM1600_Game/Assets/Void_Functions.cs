using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Void_Functions : MonoBehaviour {


public int photonTorpedoes;

	// Use this for initialization
	void Start () {
		DeathStar(photonTorpedoes);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void DeathStar (int vent){
		print("That's no moon... That's a space station!");

		if(vent == 1){
			print("Red Leader misses!");

		}
		else if(vent == 2){
			print("Use the Force, Luke...");
		}
		else{
			print("The Death Star blows up!");
		}
	}
}
