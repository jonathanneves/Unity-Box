using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AxisRawExample : MonoBehaviour {

    public float range;
	
    //GetAxisRaw ele vai direto do 0 ao 1, não tem meio termo.
    //Nao necessita de gravidade e sensivity, é instantaneo
	void Update () {
        float h = Input.GetAxisRaw("Horizontal");
        float xPos = h * range;

        transform.position = new Vector3(xPos, 2f, 0);
  
	}
}
