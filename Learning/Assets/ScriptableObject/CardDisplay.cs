using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardDisplay : MonoBehaviour {

	public Card card = null; 
	public Image artwork = null;

	void Start () {
		artwork.sprite = card.artwork;
	}
}
