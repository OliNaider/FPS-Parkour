using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MercanciaScript : MonoBehaviour
{
    public int precio = 10;
    public DineroManagment dineroManager;

    private void Start()
    {
        dineroManager = FindObjectOfType<DineroManagment>();
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player")) 
        {
            dineroManager.UpdateMoney(-precio);

            Destroy(gameObject);
            // restar precio al dinero del player
        }
    }
}
