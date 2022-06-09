using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BettingGameManager : MonoBehaviour
{
    //variable names
    //public int playerCashStack;
    public int playerChoice;
    //private int betValue;
    //private int coinResults;

    //Cash Value Manager Name
    CashValue cashValue;
    WagerValue wagerValue;

    //Text names
    public Text cashStackAmount;
    public Text playerFeedbackText;

    //Button names
    public Button bothTailsButton;
    public Button bothHeadsButton;
    public Button oneOfEachButton;
    public Button increaseBetButton;
    public Button decreaseBetButton;

    //Canvas names
    public GameObject bettingChoicesCanvas;
    public GameObject flipCoinsCanvas;
    public GameObject resultsCanvas;
    public GameObject bettingValueCanvas;

    //Camera names
    public Rigidbody Coin1;
    public Rigidbody Coin2;
    public GameObject thirdPersonCamera;
    public GameObject mainMenuCamera;


    //Group Objects / buttons
    public GameObject threeBettingButtons;
    public GameObject flipButton;
    public GameObject backButton;

    //Game Object / Coin
    public Tails tails;
    public Heads heads;
    public int result;
    public static Vector3 coinVelocity2;
    public static Vector3 coinVelocity1;

    //Other Manager Script's names set as gameobjects
    public GameObject wagerManager;
    public GameObject resultsManager;

    //Results
    public int oneOfEach = 1; 
    public int twoHeads = 2;
    public int twoTails = 0;


    void Start()
    {
        cashValue=GameObject.FindGameObjectWithTag("CashManager").GetComponent<CashValue>();
        cashValue.PlayerCashStack();


        NewGame();
    }

    private void NewGame()
    {
        //setting variable values
        //playerCashStack = 50;
        playerChoice = 0;
        cashStackAmount.text = "$" + cashValue.playerCashStack;

        //selecting canvas and camera
        flipCoinsCanvas.gameObject.SetActive(false);
        bettingValueCanvas.gameObject.SetActive(false);
        Coin1.gameObject.SetActive(false);
        Coin2.gameObject.SetActive(false);
        thirdPersonCamera.SetActive(false);
        backButton.gameObject.SetActive(false);


        bettingChoicesCanvas.gameObject.SetActive(true);
        mainMenuCamera.SetActive(true);
        flipButton.gameObject.SetActive(true);

        playerFeedbackText.text = "Welcome to Two-Up!\n What result do you think the coins will land on?";

    }

    private void BetAgain()
    {
        cashStackAmount.text = "$" + cashValue.playerCashStack;
        playerChoice = 0;

        //selecting canvas and camera
        flipCoinsCanvas.gameObject.SetActive(false);
        bettingChoicesCanvas.gameObject.SetActive(false);
        Coin1.gameObject.SetActive(false);
        Coin2.gameObject.SetActive(false);
        thirdPersonCamera.SetActive(false);
        bettingValueCanvas.SetActive(false);
        backButton.gameObject.SetActive(false);
        resultsCanvas.SetActive(false);

        bettingChoicesCanvas.gameObject.SetActive(true);
        mainMenuCamera.SetActive(true);
        threeBettingButtons.gameObject.SetActive(true);
        flipButton.gameObject.SetActive(true);


        //RESETS Bet Value, Wagered amount and the state of the text.
        GameObject.FindWithTag("WagerManager").GetComponent<WagerValue>().betAmount = 1;
        GameObject.FindWithTag("WagerManager").GetComponent<WagerValue>().wageredAmount = 0;
        wagerManager.GetComponent<WagerValue>().DisplayTheNumber();

        playerFeedbackText.text = "Welcome back, how about another bet!\n What result do you think the coins will land on?";

    }

    private void BettingMenu()
    {
        threeBettingButtons.gameObject.SetActive(false);
        bettingValueCanvas.gameObject.SetActive(true);
        backButton.gameObject.SetActive(true);
    }

  
    public void BetChoice(int buttonClicked)
    {
        if (buttonClicked == 1)
        {
            playerFeedbackText.text = "You have chosen:\n Both will land on Heads";
            BettingMenu();
            playerChoice = 1;
        }
        else if (buttonClicked == 2)
        {
            playerFeedbackText.text = "You have chosen:\n Both will land on Tails";
            BettingMenu();
            playerChoice = 2;
        }
        else if (buttonClicked == 3)
        {
            playerFeedbackText.text = "You have chosen: \n One will land on heads, one will land on tails.";
            BettingMenu();
            playerChoice = 3;
        }
        else if (buttonClicked == 4)
        {
            BetAgain();
        }



    }

    public void FlipScreen()
    {
        flipCoinsCanvas.gameObject.SetActive(true);
        Coin1.gameObject.SetActive(true);
        Coin2.gameObject.SetActive(true);
        thirdPersonCamera.SetActive(true);

        backButton.gameObject.SetActive(false);
        bettingValueCanvas.SetActive(false);

        coinVelocity1 = Coin1.velocity;
        coinVelocity2 = Coin2.velocity;

        if (playerChoice == 1)
        {
            playerFeedbackText.text = "Come on lucky Heads.";
        }
        else if (playerChoice == 2)
        {
            playerFeedbackText.text = "Come on lucky Tails.";
        }
        else if (playerChoice == 3)
        {
            playerFeedbackText.text = "Who needs luck, it's one of each.";
        }


    }

    public void ResultsScreen()
    {

        //Debug.Log("Results screen Proc");
        resultsManager.GetComponent<ResultsManager>().ResultsCalculator();
        resultsCanvas.SetActive(true);


    }


    void Update()
    {
        
    }


}
