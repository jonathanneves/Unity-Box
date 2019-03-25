using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour {

	public float speed = 2f;
	public float downMove = 0.25f;

	void Update () 
	{
		Vector3 pos = transform.position;
		pos.y += -downMove * speed * Time.deltaTime;

		if(pos.y < GameManager.GM.botBound){
			pos.y  = GameManager.GM.topBound;
		}
		transform.position = pos;
	}
}
