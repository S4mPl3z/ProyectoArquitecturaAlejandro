using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala : MonoBehaviour
{

    public float Velocidad;
    public float TiempoDeVida;

     void Reinstanciar()
    {
        Invoke("Destruir", TiempoDeVida);
    }

      void Destruir()
    {
        gameObject.SetActive(false);
    }

    // Update is called once per frame
     void Update()
    {
        transform.position += Vector3.forward * Velocidad * Time.deltaTime;
    }
}
