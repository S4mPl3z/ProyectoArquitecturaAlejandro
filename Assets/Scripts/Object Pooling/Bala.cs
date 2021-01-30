using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala : MonoBehaviour
{
    //Se crean dos variables, velocidad para darle la rapidez a la bala y el tiempodevida, que será el tiempo que tardará en destruirse.
    public float Velocidad;
    public float TiempoDeVida;

     void Reinstanciar()
    {
        Invoke("Destruir", TiempoDeVida); //Se llama a la función Destruir, para desactivar el objeto una vez se ha consumido su tiempo de vida.
    }

      void Destruir()
    {
        gameObject.SetActive(false); //Se crea éste metodo para Desactivar el objeto, y a modo de object pooling, gracias al método Instanciar, se le vuelve a 
        // asignar la posición.
    }

    // Update is called once per frame
     void Update()
    {
        transform.position += Vector3.forward * Velocidad * Time.deltaTime; //Se le modifica la posición por cada segundo que pasa a tiempo real, hacia delante.
    }
}
