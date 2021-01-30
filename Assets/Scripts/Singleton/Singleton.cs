using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Aparece en el Assets / My Assets / Nombre del Script.
[CreateAssetMenu(menuName = "My Assets/ Singleton")]


public class Singleton : ScriptableObject
{
    //Creamos un constructor privado que crea una única instancia de si misma para poder acceder a ella.
    private static readonly Singleton _instance = new Singleton(); 
    public static Singleton Instance 
    {
        get
        {
            return _instance;
        }
    }

    static Singleton() { }
    private Singleton() { }


    public void DebugFrase() // Funcion que tenemos que arrancar desde otro script, escribe una frase en el Debug.
    {
        Debug.Log("El Singleton ha funcionado correctamente");
    }

}
