using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DineroManagment : MonoBehaviour
{

    public float playerMoney;
    public UIManager uiManager;


    public void UpdateMoney(float amount)
    {
     
        if(playerMoney + amount < 0)
        {
            //impedir compra 
        } else {

           playerMoney += amount;
           uiManager.UpdatemoneyUI(playerMoney.ToString());
       
        }
    }

   
  



}
