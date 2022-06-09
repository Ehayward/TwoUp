using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResultsManager : MonoBehaviour
{
    CashValue cashValue;
    WagerValue wagerValue;
    Heads heads;
    Tails tails;

    public int playerChoice;
    public int coinResults;

    void Start()
    {
        
    }

    public void ResultsCalculator()
    {
        Debug.Log("CallingResultsCalculator");
        //_ = GameObject.FindWithTag("Heads").GetComponent<Heads>().headsResult;
        //_ = GameObject.FindWithTag("Tails").GetComponent<Tails>().tailsResult;
    }
        

    void Update()
    {
        
    }
}
