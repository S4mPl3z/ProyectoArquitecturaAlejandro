using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPooling : MonoBehaviour
{

    static Dictionary<int, Queue<GameObject>> pool = new Dictionary<int, Queue<GameObject>>(); //Se crea un diccionario, a nombre de pool, Usamos el Queue
    // para así utilizar correctamente el Object Pooling en este caso.
        

    public static void PreInstancia(GameObject objetoInstaciar, int Cantidad) // Se crea un método para realizar una preinstaciación gracias al for, Haciendolo sin fin.
    {
        pool.Add(objetoInstaciar.GetInstanceID(), new Queue<GameObject>());

        for(int i = 0; i < Cantidad; i++)
        {
            GameObject go = Instantiate(objetoInstaciar) as GameObject;
            pool[objetoInstaciar.GetInstanceID()].Enqueue(go);
            go.SetActive(false);
        }
    }

    public static void Reutilizar(GameObject objetoInstanciar, Vector3 Posicion, Quaternion rotacion) //Se crea el método reutilizar para asignar posicion, rotación y se activa la bala.
    {
        if (pool.ContainsKey(objetoInstanciar.GetInstanceID()))
        {
            GameObject go = pool[objetoInstanciar.GetInstanceID()].Dequeue();
            go.transform.position = Posicion;
            go.transform.rotation = rotacion;
            go.SetActive(true);
            go.SendMessage("Reinstanciar", SendMessageOptions.DontRequireReceiver);
            pool[objetoInstanciar.GetInstanceID()].Enqueue(go);
        }
    }
}
