using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketDestruction : MonoBehaviour {

    public float timeDestruction = 2.5f;
    void Start()
    {
        Destroy(gameObject, timeDestruction);
    }
}
