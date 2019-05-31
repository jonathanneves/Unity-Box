using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaseScript : MonoBehaviour {

    public int intelligence = 5;

    void Greet()
    {
        switch (intelligence)
        {
            case 5:
                print("Olá senhor, como está hoje? Deixe me explicar a você física quântica");
                break;
            case 4:
                print("Oi e bom dia!");
                break;
            case 3:
                print("O que você quer?");
                break;
            case 2:
                print("Eae mano, firmeza?");
                break;
            case 1:
                print("Socialismo dá certo.");
                break;
            default:
                print("Valor de inteligência incorreto.");
                break;
        }
    }
}
