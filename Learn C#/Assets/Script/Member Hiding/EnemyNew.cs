using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyNew : Humanoid {

    //This hides the Humanoid version.
    new public void Yell()
    {
        Debug.Log("Enemy version of the Yell() method");
    }
}
