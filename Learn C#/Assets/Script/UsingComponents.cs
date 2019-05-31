using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UsingComponents : MonoBehaviour {

    public GameObject otherGameObject;
    private PlayerScore anotherScript;
    private PlayerDeaths yetAnotherScript;


    //POO
    //BOA PRATICA CHAMAR NO START E AWAKE UMA VEZ SÓ
	void Awake()
    {
        anotherScript = GetComponent<PlayerScore>();
        yetAnotherScript = otherGameObject.GetComponent<PlayerDeaths>();
        //BoxCollider = GetComponent<BoxCollider>();
    }

    void Start()
    {
        Debug.Log("Player's score: " + anotherScript.playerScore);
        Debug.Log("Player has died: " + yetAnotherScript.numberOfPlayerDeaths + " times");
    }
}
