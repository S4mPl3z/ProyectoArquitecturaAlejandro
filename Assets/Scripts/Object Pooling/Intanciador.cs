using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Intanciador : MonoBehaviour
{
    //Se crea un Prefab y una cadencia, la cual determinará la velocidad de aparición del siguiente disparo.
    public float Cadencia;
    public GameObject prefabBala;
     void Start()
    {
        ObjectPooling.PreInstancia(prefabBala, 1); //Se usa la Preinstanciacion programada anteriormente, para crear 4 objetos, en donde aparecerán los objetos.

        InvokeRepeating("instanciar", 0, Cadencia); //Se invoca el método instanciar a forma de repetición para que no acabe el bucle. 
    }


      void instanciar()
    {
        ObjectPooling.Reutilizar(prefabBala, transform.position, Quaternion.identity); //Se llama a la función Reutilizar del Object Pooling, se le da el Prefab y se le asigna posición y rotacion.
    }

}
