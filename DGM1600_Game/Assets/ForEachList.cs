using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForEachList : MonoBehaviour {
	
	
	// Use this for initialization
	void Start () {
		List<FirstOrder> badguys = new List<FirstOrder>();

		badguys.Add( new FirstOrder("Snoke",1000));
		badguys.Add( new FirstOrder("General Hux",20));
		badguys.Add( new FirstOrder("Kylo Ren",400));
		badguys.Add( new FirstOrder("Captain Phasma",150));

		badguys.Sort();

		foreach(FirstOrder guy in badguys){
			print(guy.name + " " + guy.power);

            List<FirstOrder> mostWanted = new List<FirstOrder>();

		mostWanted.Add( new FirstOrder("Rey",24));
		mostWanted.Add( new FirstOrder("FN-2187",25));
		mostWanted.Add( new FirstOrder("Han Solo",66));
		mostWanted.Add( new FirstOrder("Luke Skywalker",60));
        mostWanted.Add( new FirstOrder("Leia Skywalker Solo",60));
        mostWanted.Add( new FirstOrder("Poe Dameron",27));
        mostWanted.Add( new FirstOrder("Chewbacca",79));
        mostWanted.Add( new FirstOrder("BB-8",1));
        mostWanted.Add( new FirstOrder("C-3PO", 100));
        mostWanted.Add( new FirstOrder("R2-D2",102));

		mostWanted.Sort();

		foreach(FirstOrder guy in mostWanted){
			print(guy.name + " " + guy.age);
		}
		}
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}