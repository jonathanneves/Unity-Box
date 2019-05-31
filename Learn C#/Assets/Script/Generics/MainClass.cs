using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GenericMethod
{
    public class MainClass : MonoBehaviour
    {

        void Start()
        {

            SomeClass myClass = new SomeClass();
            myClass.GenericMethod<int>(5);

            GenericClass<int> myGenericClass = new GenericClass<int>();
            myGenericClass.UpdateItem(5);
        }

    }
}
