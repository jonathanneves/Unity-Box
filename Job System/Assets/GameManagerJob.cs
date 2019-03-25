using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Jobs;
using UnityEngine.Jobs;
using UnityEngine.UI;

public class GameManagerJob : MonoBehaviour {

	TransformAccessArray transforms;
	MovementJob moveJob;
	JobHandle moveHandle;

	int count = 0;
	public Text countText;

	[Header("Bounds")]
	public float leftBound = -10f;
	public float rightBound = 10f;
	public float botBound = -5f;
	public float topBound = 5f;

	[Header("Spawn Settings")]
	public int enemyShipCount = 1;
	public int enemyShipIncrement = 1;
	public float enemySpeed = 2f;
	public GameObject enemyShipPrefab;

	void OnDisable()
	{
		moveHandle.Complete();
		transforms.Dispose();
	}


	void Start () 
	{
		transforms = new TransformAccessArray(0, -1);
		AddShips(enemyShipCount);
	}

	void Update () 
	{
		moveHandle.Complete();
		if(Input.GetKeyDown("space"))
			AddShips(enemyShipIncrement);

		moveJob = new MovementJob()
		{
			moveSpeed = enemySpeed,
			topBound = topBound,
			botBound = botBound,
			deltaTime = Time.deltaTime
		};

		moveHandle = moveJob.Schedule(transforms);

		JobHandle.ScheduleBatchedJobs(); //Chuta pra fora inves de esperar + Jobs	
	}

	void AddShips(int amount)
	{
		moveHandle.Complete();

		transforms.capacity = transforms.length + amount;

		for(int i = 0;  i < amount; i++)
		{
			float xVal = Random.Range(leftBound, rightBound);
			float yVal = Random.Range(0f, 5.5f);

			Vector3 pos = new Vector3(xVal, yVal + topBound, 0f);
			Quaternion rot = Quaternion.Euler(0f, 180f, 0f);

			var obj = Instantiate(enemyShipPrefab, pos, rot) as GameObject;

			transforms.Add(obj.transform);
		}

		count += amount;
		countText.text = "Total:" + count;
//		fps.SetElementCount(count);
	}
}
