using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Craft", menuName = "Craft")]
public class Craft : ScriptableObject {

	public Card card1;
	public Card card2;
	
	public Card result;
}
