using System;
using Unity.Entities;
using UnityEngine;

[Serializable]
public struct Position : IComponentData 
{
	public Vector3 Value;
}
	
public class PositionComponent : ComponentDataWrapper<Position>{ }

