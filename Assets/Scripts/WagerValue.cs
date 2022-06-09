using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WagerValue : MonoBehaviour
{
    [SerializeField] Text textDisplayNumber;

    CashValue cashValue;
    int playerCashStack;

    public GameObject increaseButton;
    public GameObject decreaseButton;

    public int betAmount = 1;
    public int wageredAmount;


    void Start()
    {
        DisplayTheNumber();
    }

    public void IncreaseAndDisplay()
    {
        IncreaseTheValueBy1();
        DisplayTheNumber();
    }
    public void DecreaseAndDisplay()
    {
        DecreaseTheValueBy1();
        DisplayTheNumber();
    }

    private void IncreaseTheValueBy1()
    {

       if (betAmount == GameObject.FindWithTag("CashManager").GetComponent<CashValue>().playerCashStack)
       {

       }
        else
        {
            betAmount++;
        } 
      
    }

    private void DecreaseTheValueBy1()
    {
        if (betAmount == 1)
        {

        }
        else
        {
            betAmount--;
        }

    }


    void DisplayTheNumber()
    {
        textDisplayNumber.text = "$" + betAmount.ToString();

        //Disables and re-enables button if the amount of the bet equals the cashstack, if it doesn't button is active.
        if (betAmount == GameObject.FindWithTag("CashManager").GetComponent<CashValue>().playerCashStack)
        {
            increaseButton.SetActive(false);
        }
        else if (betAmount != GameObject.FindWithTag("CashManager").GetComponent<CashValue>().playerCashStack)
        {
            increaseButton.SetActive(true);
        }

        //Disables and re-enables button if the amount of the bet is $1, it its above then its enabled.
        if (betAmount == 1)
        {
            decreaseButton.SetActive(false);
        }
        else if (betAmount >= 1)
        {
            decreaseButton.SetActive(true);
        }   
    }
    public void LockInBet()
    {
        wageredAmount = betAmount;
    }

    public void ResetBetAmount()
    {
        betAmount = 1;
    }

    void Update()
    {

    }
}
