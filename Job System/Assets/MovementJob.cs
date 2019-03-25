using System.Collections;
using System.Collections.Generic;
using Unity.Jobs;
using UnityEngine;
using UnityEngine.Jobs;

//[ComputeJobOptimization]
public struct MovementJob : IJobParallelForTransform {

	public float moveSpeed;
	public float topBound;
	public float botBound;
	public float deltaTime;

	public void Execute(int index, TransformAccess transform){

		Vector3 pos = transform.position;
		pos += moveSpeed * deltaTime * (transform.rotation * new Vector3(0f, -0.25f, 0f));

		if(pos.y < botBound){
			pos.y  = topBound;
		}

		transform.position = pos;
		
	}
	
}
