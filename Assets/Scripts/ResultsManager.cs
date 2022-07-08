using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResultsManager : MonoBehaviour
{
    WagerValue wagerValue;
    BettingGameManager bettingGameManager;


    int coin1Heads;
    int coin1Tails;
    int coin1Side;

    int coin2Heads;
    int coin2Tails;
    int coin2Side;

    public int playerCashStack;

    public GameObject heads1;
    public GameObject tails1;
    public GameObject side1;

    public GameObject cashValue;
    public GameObject bettingManager;

    public GameObject heads2;
    public GameObject tails2;
    public GameObject side2;

    public Text resultText;

    public int playerChoice;


    void Start()
    {

    }

    
    public void ResultsCalculator(int buttonClicked)
    {

        //Heads = 1
        //Tails = 0

        if (buttonClicked == 1)
        {
            Debug.Log("BOTH HEADS");
            playerChoice = 1;
        }
        else if (buttonClicked == 2)
        {
            Debug.Log("BOTH TAILS");
            playerChoice = 2;
        }
        else if (buttonClicked == 3)
        {
            Debug.Log("ONE OF EACH");
            playerChoice = 3;
        }
        else if (buttonClicked == 4)
        {
            bettingGameManager.GetComponent<BettingGameManager>().BetAgain();
        }

    }

    public void Payout()
    {
       
        int heads1result = heads1.GetComponent<Heads>().Result();
        int tails1result = tails1.GetComponent<Tails>().Result();
        int heads2result = heads2.GetComponent<Heads>().Result();
        int tails2result = tails2.GetComponent<Tails>().Result();

        Debug.Log(heads1result);
        Debug.Log(tails1result);
        Debug.Log(heads2result);
        Debug.Log(tails2result);

        playerCashStack = GameObject.FindWithTag("CashManager").GetComponent<CashValue>().playerCashStack;



        if (playerChoice == 1 && (heads1result + heads2result + tails2result + tails1result == 2))
        {
            cashValue.GetComponent<CashValue>().CashStackAfterWin();
            bettingManager.GetComponent<BettingGameManager>().WinnerScreen();
            resultText.text = "Your bet was correct!";

            Debug.Log("Win Triggered");
        }
        else
        {
            if (playerChoice == 2 && (heads1result + heads2result + tails2result + tails1result == 0))
            {
                cashValue.GetComponent<CashValue>().CashStackAfterWin();
                bettingManager.GetComponent<BettingGameManager>().WinnerScreen();
                resultText.text = "Your bet was correct!";
                Debug.Log("Win Triggered");
            }
            else
            {
                if (playerChoice == 3 && (heads1result + heads2result + tails2result + tails1result == 1))
                {
                    cashValue.GetComponent<CashValue>().CashStackAfterOOEWin();
                    bettingManager.GetComponent<BettingGameManager>().WinnerScreen();
                    resultText.text = "Your bet was correct!";
                    Debug.Log("Win Triggered");
                }
                else
                {
                    resultText.text = "Your bet was incorrect!";
                    bettingManager.GetComponent<BettingGameManager>().LosersScreen();

                    Debug.Log("Loss Triggered");
                    if (playerCashStack <= 0)
                    {

                        bettingManager.GetComponent<BettingGameManager>().GamerOverScreen();
                    }
                }
            
            }

        }

    }
}
