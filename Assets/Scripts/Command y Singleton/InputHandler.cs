using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandler : MonoBehaviour
{

    //Creamos los objetos para los materiales, declaramos el Command y los nombres necesarios para realizar las funciones dentro del Command, y un GameObject que sea la Bala
    public Material Objeto;
    public Material Objeto2;
    public Command cambiarAzul, cambiarRojo;
    GameObject balas;

    void Start()
    {
        //Declaramos en el Start Las funciones del comando Command.
        cambiarAzul = new CambiarColorAzul();
        cambiarRojo = new CambiarColorRojo();    
    }
    void Update()
    {
        //Declaramos las funciones Internas para cambiar los colores.
        ChangeColorRojo();
        ChangeColorAzul();
    }

    public void ChangeColorAzul()
    {
        //Declaramos la funcion que trata de cambiar el color si se pulsa la tecla F, los disparos se vuelven azules.

        if (Input.GetKeyDown(KeyCode.F))
        {
            balas = GameObject.FindGameObjectWithTag("balas");
            cambiarAzul.Execute(Objeto, balas);
        }
    }
    public void ChangeColorRojo()
    {
        //Declaramos la funcion que trata de cambiar el color si se pulsa la tecla G, los disparos se vuelven rojos.

        if (Input.GetKeyDown(KeyCode.G))
        {
            balas = GameObject.FindGameObjectWithTag("balas");
            cambiarRojo.Execute(Objeto2, balas);
        }
    }
}
