using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

	public static GameManager GM;
	int count = 0;
	public Text countText;
	//EntityManager manager;
//	FPS fps;

	[Header("Bounds")]
	public float leftBound = -10f;
	public float rightBound = 10f;
	public float botBound = -5f;
	public float topBound = 5f;

	[Header("Spawn Settings")]
	public int enemyShipCount = 1;
	public int enemyShipIncrement = 1;
	public GameObject enemyShipPrefab;


	void Awake()
	{
		if(GM != null)
			return;

		GM = this;
	}

	void Start () {
	//	fps = GetComponent<FPS>();
		//manager = World.Active.GetOrCreateManager<EntityManager>();
		AddShips(enemyShipCount);
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown("space"))
			AddShips(enemyShipIncrement);
	}

	void AddShips(int amount)
	{
		for(int i = 0;  i < amount; i++)
		{
			float xVal = Random.Range(leftBound, rightBound);
			float yVal = Random.Range(0f, 5.5f);

			Vector3 pos = new Vector3(xVal, yVal + topBound, 0f);
			Quaternion rot = Quaternion.Euler(0f, 180f, 0f);

			var obj = Instantiate(enemyShipPrefab, pos, rot) as GameObject;
		}

		count += amount;
		countText.text = "Total:" + count;
//		fps.SetElementCount(count);
	}


}
