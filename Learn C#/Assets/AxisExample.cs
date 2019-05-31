using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AxisExample : MonoBehaviour {

    public float range;
    public Text txtGetAxis;	

    //EM INPUT MANAGER

    //AUMENTAR A GRAVIDADE VOLTA MAIS RAPIDAMENTE AO CENTRO;
    //DIMINUIR A GRAVIDADE VOLTA MAIS DEVAGAR
   
    //AUMENTAR A SENSIVITY MAIS RAPIDO ELE VAI AO DESTINO;
    //DIMUNUIR A SENSIVITY MAIS DEVAGAR;
	void Update () {
        float h = Input.GetAxis("Horizontal");
        float xPos = h * range;

        float v = Input.GetAxis("Vertical");
        float yPos = v * range;

        //transform.position = new Vector3(xPos, 2f, 0);
        transform.position = new Vector3(xPos, yPos+2f, 0);
        txtGetAxis.text = "Valor Axis Retornado: " + h.ToString("F2");
    }
}
