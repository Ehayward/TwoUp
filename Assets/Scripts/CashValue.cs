using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CashValue : MonoBehaviour
{
    public int playerCashStack;
    public Text cashStackAmount;

    void Start()
    {


    }

    public void PlayerCashStack()
    {
        cashStackAmount.text = "$" + playerCashStack;
    }

    public void CashStackAfterBet()
    {
        playerCashStack -= GameObject.FindWithTag("WagerManager").GetComponent<WagerValue>().wageredAmount;
        PlayerCashStack();
    }

    public void CashStackAfterWin()
    {
        playerCashStack += (GameObject.FindWithTag("WagerManager").GetComponent<WagerValue>().wageredAmount * 4);
        PlayerCashStack();
    }
    public void CashStackAfterOOEWin()
    {
        playerCashStack += (GameObject.FindWithTag("WagerManager").GetComponent<WagerValue>().wageredAmount * 2);
        PlayerCashStack();
    }

    public void ResetCashStack()
    {
        playerCashStack = 5;
    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
