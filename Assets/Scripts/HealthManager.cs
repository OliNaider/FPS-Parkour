using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthManager : MonoBehaviour
{
    public float playerHealth;
    public UIManager uiManager;


    public bool UpdateHealth(float damage)
    {

        if (playerHealth + damage < 0)
        {
            //impedir compra 
            return false;

        }
        else
        {

            playerHealth += damage;
            uiManager.UpdateHealthUI(playerHealth.ToString());
            return true;

        }
    }

    private void Start()
    {
        uiManager.UpdateHealthUI(playerHealth.ToString());
    }
}
