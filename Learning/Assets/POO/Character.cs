using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character{

	public string charName;
	public int health;
	public int speed;
	public int damage;

	public Character(string nome, int health, int speed, int damage){
		this.charName = nome;
		this.health = health;
		this.speed = speed;
		this.damage = damage;		
	}

	public void takenDamage(){
		Debug.Log("Tomou Dano");
	}

	public void information(){
		Debug.Log(charName + " Vida: "+ health + " Speed: "+ speed + " Damage: "+ damage );
	}
}
