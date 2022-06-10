using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResultsManager : MonoBehaviour
{
    CashValue cashValue;
    BettingGameManager bettingGameManager;

    int coin1Heads;
    int coin1Tails;
    int coin1Side;

    int coin2Heads;
    int coin2Tails;
    int coin2Side;

    //Tails results = 0
    //Heads resutls = 1
    public GameObject heads1;
    public GameObject tails1;
    public GameObject side1;

    public GameObject heads2;
    public GameObject tails2;
    public GameObject side2;

    void Start()
    {

    }

    
    public void ResultsCalculator()
    {
        Debug.Log("CallingResultsCalculator");

        heads1.GetComponent<Heads>().Result();
        tails1.GetComponent<Tails>().Result();

        heads2.GetComponent<Heads>().Result();
        tails2.GetComponent<Tails>().Result();

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
