using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basic : MonoBehaviour {

    private void Awake()
    {
        Debug.Log("AWAKE: inicia antes do Start e funciona com Script desabilitado");
    }
    void Start () {
        Debug.Log("START: inicia depois e só funciona com Script habilitado");
	}

    private void FixedUpdate()
    {
        Debug.Log("FIXEDUPDATE: Chamado a cada passo da física");
        Debug.Log("Usado para updates como ajustar objetos rigidbody. Intervalos consistente");
        Debug.Log("FixedUpdate time: " + Time.deltaTime);
    }

    void Update () {
        Debug.Log("UPDATE: Chamado a cada frame");
        Debug.Log("Usado para simples updates: Mover objetos sem física, times, e receber inputs");
        Debug.Log("Update time: " + Time.deltaTime);
	}
}
