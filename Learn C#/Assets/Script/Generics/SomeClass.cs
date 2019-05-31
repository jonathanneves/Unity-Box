using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GenericMethod {

    public class SomeClass : MonoBehaviour
    {

        //Metodo Generico, T assume qualquer valor definido
        //T, U, V

        // public T GenericeMethos<T>(T param) where T : struct
        public T GenericMethod<T>(T param)
        {
            return param;
        }
    }
}
