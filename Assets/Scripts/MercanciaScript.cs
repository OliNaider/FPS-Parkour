﻿using System.Collections;
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
            // restar precio al dinero del player
            if (dineroManager.UpdateMoney(-precio))
            {
                Destroy(gameObject);
            }
  
        }
    }
}
