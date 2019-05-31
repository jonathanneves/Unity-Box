using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStatic : MonoBehaviour {

    void Start()
    {
        Enemy enemy1 = new Enemy();
        Enemy enemy2 = new Enemy();
        Enemy enemy3 = new Enemy();

        int x = Enemy.enemyCount;
        int soma = Enemy.Add(5, 6);

        print("Total de inimigos: "+ x + " Soma total: " + soma);

        //Porcausa do static como extensão de método, o this transform como parâmetro, pode ser chamado em qualquer classe
        transform.ResetTransformation();
    }	
}
