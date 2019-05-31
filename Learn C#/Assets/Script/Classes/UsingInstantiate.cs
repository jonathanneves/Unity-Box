using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UsingInstantiate : MonoBehaviour {

    public Rigidbody rocketPrefab;
    public Transform barrelEnd;
    public float speed = 500;

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            //Instantiate(rocketPrefab, barrelEnd.position, barrelEnd.rotation) as Rigidbody;
            Rigidbody rocketInstance;
            rocketInstance = Instantiate(rocketPrefab, barrelEnd.position, barrelEnd.rotation) as Rigidbody;
            rocketInstance.AddForce(barrelEnd.forward * speed);
        }
    }
}
