using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseClick : MonoBehaviour {

    private Rigidbody rigidbody;

    private void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    void OnMouseDown()
    {
        rigidbody.AddForce(transform.forward * 500);
        rigidbody.useGravity = true;
        Debug.Log("Clicou no cubo!");
    }
}
