using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarBand : MonoBehaviour {

    void Start()
    {
        Humanoid human = new Humanoid();
        Humanoid enemy = new EnemyNew();
        Humanoid orc = new Orc();

        //Note que cada variavel humanoide
        //referencia a uma diferente classe da hierarquia
        //porem cada uma chama o mesmo metodo Yell() do Humanoid
        human.Yell();
        enemy.Yell();
        orc.Yell();
    }
}
