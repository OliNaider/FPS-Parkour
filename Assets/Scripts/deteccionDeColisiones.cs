using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deteccionDeColisiones : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("contacto");
        Destroy(gameObject); //el objeto que tiene el scritpt 
    }
}
