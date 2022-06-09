using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResultsManager : MonoBehaviour
{
    CashValue cashValue;
    BettingGameManager bettingGameManager;


    void Start()
    {
        
    }

    public void ResultsCalculator()
    {
        Debug.Log("CallingResultsCalculator");
    }

    public void PlayersChoice(int buttonClicked)
    {
        int playerChoice = GameObject.FindWithTag("BettingManager").GetComponent<BettingGameManager>().playerChoice;

        if (buttonClicked == 1)
        {
            Debug.Log("HEADS");
            playerChoice = 1;
        }
        else if (buttonClicked == 2)
        {
            Debug.Log("TAILS");
            playerChoice = 2;
        }
        else if (buttonClicked == 3)
        {
            Debug.Log("ONE OF EACH");
            playerChoice = 3;
        }
    }


    void Update()
    {
        
    }
}
