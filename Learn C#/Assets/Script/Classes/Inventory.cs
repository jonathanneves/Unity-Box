using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{

    public class Stuff
    {
        public int bullets;
        public int grenades;
        public int rockets;

        public Stuff(int bul, int gre, int roc)
        {
            bullets = bul;
            grenades = gre;
            rockets = roc;
        }
    }

    public Stuff myStuff = new Stuff(50, 5, 5);

    void Start()
    {
        Debug.Log(myStuff.bullets);
    }
}
