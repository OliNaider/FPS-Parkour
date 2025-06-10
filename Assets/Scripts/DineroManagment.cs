using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DineroManagment : MonoBehaviour
{

    public float playerMoney;
    public UIManager uiManager;


    public bool UpdateMoney(float amount)
    {
     
        if(playerMoney + amount < 0)
        {
            //impedir compra 
            return false;
           
        } else {

           playerMoney += amount;
           uiManager.UpdatemoneyUI(playerMoney.ToString());
           return true;

        }
    }

    private void Start()
    {
        uiManager.UpdatemoneyUI(playerMoney.ToString());
    }





}
