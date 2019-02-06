using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero : MonoBehaviour {


	void Start () {

		Character hero = new Character("John",20,30,5);
		hero.information();
	}
}
