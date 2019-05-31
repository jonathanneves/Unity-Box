using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ListAndDictionaries
{
    public class SomeClass : MonoBehaviour
    {
        private void Start()
        {
            List<BadGuy> badguys = new List<BadGuy>();

            badguys.Add( new BadGuy("Ricardo", 50));
            badguys.Add( new BadGuy("Joãozinho", 50));
            badguys.Add( new BadGuy("Fumaça", 50));

            badguys.Sort();
            foreach(BadGuy guy in badguys)
            {
                print(guy.name + " " + guy.power);
            }
            badguys.Clear();
        }
    }
}
