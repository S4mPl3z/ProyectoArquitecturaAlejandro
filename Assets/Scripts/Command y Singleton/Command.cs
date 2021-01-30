using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Command //Se crea la clase Command, con un Execute para realizar el comando que tenemos ideado.
{
    public abstract void Execute(Material Azul, GameObject go);
}

public class CambiarColorAzul : Command //Se crea la clase cambiar color que derive de command, con una funcion que cambiar el color del GameObject a azul mientras pulsas la F.
{
    public override void Execute(Material Azul, GameObject go)
    {   
            go.GetComponent<MeshRenderer>().material = Azul;    
    }

}

public class CambiarColorRojo : Command //Se crea la clase cambiar color que derive de command, con una funcion que cambiar el color del GameObject a rojo mientras pulsas la G.
{
    public override void Execute(Material Rojo, GameObject go)
    {
        go.GetComponent<MeshRenderer>().material = Rojo;
    }

}
public class DoNothing : Command
{
    public override void Execute(Material Azul, GameObject go)
    {
    }
}



