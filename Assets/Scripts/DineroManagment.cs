using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DineroManagment : MonoBehaviour
{

    public float playerMoney;
    public UIManager UiManager;


    public void UpdateMoney(float amount)
    {
     
        if(playerMoney + amount < 0)
        {
            //impedir compra 
        } else {

           playerMoney += amount;
           UiManager.UpdatemoneyUI(playerMoney.ToString());
       
        }
    }

   
  



}
