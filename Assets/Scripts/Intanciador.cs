using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Intanciador : MonoBehaviour
{
    public float Cadencia;
    public GameObject prefabBala;
     void Start()
    {
        ObjectPooling.PreInstancia(prefabBala, 4);

        InvokeRepeating("instanciar", 0, Cadencia);
    }


      void instanciar()
    {
        ObjectPooling.Reutilizar(prefabBala, transform.position, Quaternion.identity);
    }

}
