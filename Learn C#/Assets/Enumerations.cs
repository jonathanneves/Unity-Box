using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enumerations : MonoBehaviour {

    //enum Direction { North = 10, East = 11, South = 12, West = 13 };
    //enum Direction : short { North, East, South, West }   declarar o tipo
    enum Direction {  North, East, South, West }; 

	void Start ()
    {
        Direction myDirection;

        myDirection = Direction.North;

	}

    Direction ReverseDirection(Direction dir)
    {
        if (dir == Direction.North)
            dir = Direction.South;
        else if (dir == Direction.South)
            dir = Direction.North;
        else if (dir == Direction.East)
            dir = Direction.West;
        else if (dir == Direction.West)
            dir = Direction.East;

        return dir;
    }

}
