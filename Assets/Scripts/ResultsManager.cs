using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResultsManager : MonoBehaviour
{
    CashValue cashValue;
    WagerValue wagerValue;
    BettingGameManager bettingGameManager;

    int coin1Heads;
    int coin1Tails;
    int coin1Side;

    int coin2Heads;
    int coin2Tails;
    int coin2Side;

    public bool bothHeadsResult;
    public bool bothTailsResult;
    public bool oneOfEachResult;

    public GameObject heads1;
    public GameObject tails1;
    public GameObject side1;

    public GameObject heads2;
    public GameObject tails2;
    public GameObject side2;


    void Start()
    {
        bothHeadsResult = false;
        bothTailsResult = false;
        oneOfEachResult = false;
    }

    
    public void ResultsCalculator()
    {

        int heads1result = heads1.GetComponent<Heads>().Result();
        int tails1result = tails1.GetComponent<Tails>().Result();

        int heads2result = heads2.GetComponent<Heads>().Result();
        int tails2result = tails2.GetComponent<Tails>().Result();

        //Debug.Log("Coin 1 " + heads1result);
        //Debug.Log("Coin 1 " + tails1result);
        //Debug.Log("Coin 2 " + tails2result);
        //Debug.Log("Coin 2 " + heads2result);

        //Tails results = 0
        //Heads resutls = 1

        if (heads1result + tails1result + heads2result + tails2result == 2)
        {
            bothHeadsResult = true;
        }
        else if (heads1result + tails1result + heads2result + tails2result == 0)
        {
            bothTailsResult = true;
        }
        else if (heads1result + tails1result + heads2result + tails2result == 1)
        {
            oneOfEachResult = true;
        }

        //Debug.Log("Both Heads " + bothHeadsResult);
        //Debug.Log("Both Tails " + bothTailsResult);
        //Debug.Log("One of Each " + oneOfEachResult);

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
