using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI TxTMoney;
    
    void Start() {
        
    }

   public void  UpdatemoneyUI(string moneyAmount)
    {
        TxTMoney.text = moneyAmount;
;
    }
}
