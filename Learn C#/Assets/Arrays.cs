using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrays : MonoBehaviour {

    int[] myIntArray = { 12, 76, 8, 95, 20 };
    public GameObject[] players; 

	void Start () {
        /* myIntArray[0] = 12;	
         myIntArray[1] = 14;	
         myIntArray[2] = 53;	
         myIntArray[3] = 34;	
         myIntArray[4] = 20;*/

       // players = GameObject.FindGameObjectsWithTag("Player");
        for(int i = 0; i< myIntArray.Length; i++)
        {
            Debug.Log("VALOR " + i + " é " + myIntArray[i]);
            //Debug.Log("Player Number " + i + " is named " + players[i].name);
        }
    }	
}
