using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HurtingObject : MonoBehaviour
{
    public int daño = 10;
    public HealthManager healthManager;

    private void Start()
    {
        healthManager = FindObjectOfType<HealthManager>();
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            // restar precio al dinero del player
            if (healthManager.UpdateHealth(-daño))
            {
                Destroy(gameObject);
            }

        }
    }
}
