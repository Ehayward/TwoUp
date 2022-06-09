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

    // Update is called once per frame
    void Update()
    {
        
    }
}
