using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeltaTime : MonoBehaviour {

    public float speed = 8f;
    private float countdown = 3f;
    public float delayTime = 3f;

    public Light light;

	void Update () {

        //TIMER
        if (countdown <= 0f)
        {
            light.enabled = !light.enabled;
            countdown = delayTime;
        }
        else
        {
            countdown -= Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            //Movimento mais smoothing
            transform.position += new Vector3(speed * Time.deltaTime, 0f, 0f);
        }
	}
}
