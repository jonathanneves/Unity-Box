using Unity.Collections;
using Unity.Entities;
using Unity.Jobs;
using Unity.Mathematics;
using Unity.Transforms;
using UnityEngine;

public class MovementSystem : JobComponentSystem {

	struct MovementJob : IJobProcessComponentData<Position, Rotation, MoveSpeed>
	{
		public float topBound;
		public float botBound;
		public float deltaTime;

		public void Execute (ref Position position, ref Rotation rotation, ref MoveSpeed movespeed)
		{
			float3 value = position.Value;
			value += deltaTime * speed.Value * math.forward(rotarion.Value);

			if(value.y < bottomBound)
				value.y = topBound;

			position.Value = value;
		}	
	}
	
	protected override JobHandle OnUpdate(JobHandle inputDeps)
	{
		MovementJob moveJob = new MovementJob
		{
			topBound = GameManager.GM.topBound,
			botBound = GameManager.GM.botBound,
			deltaTime = Time.deltaTime
		};

		JobHandle moveHandle = moveJob.Schedule(this, 64, inputDeps);

		return moveHandle;
	}	
}
