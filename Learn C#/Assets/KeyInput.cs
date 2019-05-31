using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeyInput : MonoBehaviour {

    public Text txtGetButtonDown;
    public Text txtGetButton;
    public Text txtGetButtonUp;

	void Update () {
        bool down = Input.GetButtonDown("Jump");   //Input.GetKeyDown(KeyCode.Space);
        bool held = Input.GetButton("Jump");       //Input.GetKey(KeyCode.Space);
        bool up = Input.GetButtonUp("Jump");       //Input.GetKeyUp(KeyCode.Space);

        txtGetButtonDown.text = "GetButtonDown: " + down;
        txtGetButton.text = "GetButton: " + held;
        txtGetButtonUp.text = "GetButtonUp: " + up;

    }
}
