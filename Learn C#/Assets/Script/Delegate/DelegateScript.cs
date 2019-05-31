using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelegateScript : MonoBehaviour {

    delegate void MyDelegate(int num);
    MyDelegate myDelegate;

    delegate void MultiDelegate();
    MultiDelegate myMultiDelegate;

    void Start () {
        myDelegate = PrintNum;
        myDelegate(50);

        myDelegate = DoubleNum;
        myDelegate(50);

        //Stackar metodos
        myMultiDelegate += PowerUp;
        myMultiDelegate += TurnRed;

        if (myMultiDelegate != null)
        {
            myMultiDelegate();
        }
    }

    //MyDelegate
    void PrintNum(int num)
    {
        print("Print num: " + num);
    }

    void DoubleNum(int num)
    {
        print("Double num: " + num * 2);
    }

    //MultiDelegate
    void PowerUp()
    {
        print("Orb is powering up!");

    }

    void TurnRed()
    {
        print("Material agora é vermelho");
       // renderer.material.color = Color.red;
    }
}
