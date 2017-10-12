using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class FirstOrder : IComparable<FirstOrder> {

		public string name;
		public int power;
		public int age;

		public FirstOrder(string newName, int newPower, int newAge){
			name = newName;
			power = newPower;
			age = newAge;
		}

		public int CompareTo(FirstOrder other)
		{
			if(other == null){
				return 1;
			}

			return power - other.power;
			
		}

}
