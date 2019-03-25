using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Entities;

public class GameManagerECS : MonoBehaviour {

	public static GameManager GM;
	int count = 0;
	public Text countText;
	EntityManager manager;
//	FPS fps;

	[Header("Bounds")]
	public float leftBound = -10f;
	public float rightBound = 10f;
	public float botBound = -5f;
	public float topBound = 5f;

	[Header("Spawn Settings")]
	public int enemyShipCount = 1;
	public int enemyShipIncrement = 1;
	public int enemySpeed = 2f;
	public GameObject enemyShipPrefab;


	void Awake()
	{
		if(GM != null)
			return;

		GM = this;
	}

	void Start () {
	//	fps = GetComponent<FPS>();
		manager = World.Active.GetOrCreateManager<EntityManager>();
		AddShips(enemyShipCount);
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown("space"))
			AddShips(enemyShipIncrement);
	}

	void AddShips(int amount)
	{
		NativeArray<Entity> entities = new NativeArray<Entity>(amount, Allocator.Temp);
		manager.Instantiate(enemyShipPrefab, entities);

		for(int i = 0;  i < amount; i++)
		{
			float xVal = Random.Range(leftBound, rightBound);
			float yVal = Random.Range(0f, 5.5f);
			manager.SetComponentData(entities[i], new Position {Value = new flaot3(xVal, yVal + topBound, 0)});
			manager.SetComponentData(entities[i], new Rotation {Value = new Quaternion(0,1,0,0)});
			manager.SetComponentData(entities[i], new MoveSpeed {Value = enemySpeed});
		}
		entities.Dispose();
		count += amount;
		countText.text = "Total:" + count;
//		fps.SetElementCount(count);
	}


}
