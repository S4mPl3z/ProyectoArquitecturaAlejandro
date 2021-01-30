using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SingletonTest : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E)) // Se Hace un lector de inputs para cuando se le pulse la tecla E, inicie la funcion dentro del singleton.
        {
            Singleton.Instance.DebugFrase(); //Inicia La funcion cogiendo la información desde el Singleton.
        }
    }
}
