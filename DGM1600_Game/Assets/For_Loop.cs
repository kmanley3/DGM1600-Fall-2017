using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class For_Loop : MonoBehaviour {
	// public int bottles = 100;
	// Use this for initialization
	void Start () {
		// while(bottles > 0){
		// 	print(bottles+" of beer on the wall.");
		// 	bottles --;
		// }
		for(int bottles = 100; bottles > 0; bottles --){
			print(bottles + " bottles of beer on the wall.");
		}
		for(int pork = 0; pork < 100; pork ++){
			print(pork + " pigs have escaped!");
		}
		for(int skeletons = 45; skeletons > 0; skeletons --){
			print(skeletons + " spooky scary skeletons.");
		}
		for(int zombies = 0; zombies < 77; zombies ++){
			print(zombies + " zombies in the hoard!");
		}
		for(int pixieSticks = 94; pixieSticks > 35; pixieSticks --){
			print(pixieSticks + " pixie sticks left. Don't eat them all.");
		}
		for(int cranberries = 3; cranberries < 10; cranberries ++){
			print(cranberries + " cranberries in the basket.");
		}
		for(int tacos = 55; tacos < 100; tacos ++){
			print(tacos + " tacos. It will never be enough.");
		}
		for(int gremlins = 90; gremlins > 30; gremlins--){
			print(gremlins + " gremlins left to kill. Muahahahaha!! Get those suckers outta here!");
		}
		for(int rebels = 0; rebels < 100; rebels ++){
			print(rebels + " rebels have joined the cause!");
		}
		for(int bullets = 40; bullets > 0; bullets --){
			print(bullets + " bullets left. Use them wisely!");
		}

		//For loops: an explanation. They're exactly the same as while loops, but even easier - syntax wise. Amazing!
		//In the same parentheses, you can declare your value, your parameter and your incremement.
		//They are much faster than while loops. Happy day.
	}
	// Update is called once per frame
	// void Update () {
		
	// }
}
