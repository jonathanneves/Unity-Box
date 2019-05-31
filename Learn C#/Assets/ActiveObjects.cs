using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveObjects : MonoBehaviour {

    public GameObject myObject;

	void Start () {
        myObject.SetActive(false);
        Debug.Log("Está ativado: " + myObject.activeSelf);
        Debug.Log("Está ativado na hierarquia: " + myObject.activeInHierarchy);
	}
	
}
