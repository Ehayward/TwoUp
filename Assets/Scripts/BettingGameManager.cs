using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BettingGameManager : MonoBehaviour
{
    //SoundManager
    public SoundManager soundManager;
    //Option variable.
    public int playerChoice;

    //Other Manager Scripts
    CashValue cashValue;
    WagerValue wagerValue;

    //Text names
    public Text cashStackAmount;
    public Text playerFeedbackText;
    public Text resultText;

    //Button names
    public Button bothTailsButton;
    public Button bothHeadsBFutton;
    public Button oneOfEachButton;
    public Button increaseBetButton;
    public Button decreaseBetButton;

    //Canvas names
    public GameObject bettingChoicesCanvas;
    public GameObject flipCoinsCanvas;
    public GameObject resultsCanvas;
    public GameObject bettingValueCanvas;
    public GameObject constantCanvas;

    //Camera names
    public GameObject Coin1;
    public GameObject Coin2;
    public GameObject thirdPersonCamera;
    public GameObject mainMenuCamera;


    //Group Objects / buttons
    public GameObject threeBettingButtons;
    public GameObject flipButton;
    public GameObject backButton;
    public GameObject newGameButton;

    //Game Object / Coin data
    public Tails tails;
    public Heads heads;
    public int result;
    public static Vector3 coinVelocity2;
    public static Vector3 coinVelocity1;

    //Other Manager Script's names set as gameobjects
    public GameObject wagerManager;
    public GameObject resultsManager;

    void Start()
    {

        NewGame();
        soundManager.ambiance.clip = soundManager.backgroundConversation;
        soundManager.ambiance.Play();
        Debug.Log("NewGame");
    }

    public void NewGame()
    {
        cashValue = GameObject.FindGameObjectWithTag("CashManager").GetComponent<CashValue>();
        cashValue.ResetCashStack();

        GameObject.FindWithTag("WagerManager").GetComponent<WagerValue>().betAmount = 1;
        GameObject.FindWithTag("WagerManager").GetComponent<WagerValue>().wageredAmount = 0;
        wagerManager.GetComponent<WagerValue>().DisplayTheNumber();


        playerChoice = 0;
        cashStackAmount.text = "$" + cashValue.playerCashStack;

        //selecting canvas and camera
        flipCoinsCanvas.gameObject.SetActive(false);
        bettingChoicesCanvas.gameObject.SetActive(false);
        Coin1.gameObject.SetActive(false);
        Coin2.gameObject.SetActive(false);
        thirdPersonCamera.SetActive(false);
        bettingValueCanvas.SetActive(false);
        backButton.gameObject.SetActive(false);
        resultsCanvas.SetActive(false);
        newGameButton.gameObject.SetActive(false);

        bettingChoicesCanvas.gameObject.SetActive(true);
        mainMenuCamera.SetActive(true);
        threeBettingButtons.gameObject.SetActive(true);
        flipButton.gameObject.SetActive(true);


        resultText.text = "";
        playerFeedbackText.text = "Welcome to Two-Up!\n What result do you think the coins will land on?";

    }

    public void BetAgain()
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

        resultText.text = "";


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
            playerFeedbackText.text = "You have chosen:\n Both will land on Heads\n You will get x4 back from your bet if you are correct.";
            BettingMenu();
            playerChoice = 1;
        }
        else if (buttonClicked == 2)
        {
            playerFeedbackText.text = "You have chosen:\n Both will land on Tails\n You will get x4 back from your bet if you are correct.";
            BettingMenu();
            playerChoice = 2;
        }
        else if (buttonClicked == 3)
        {
            playerFeedbackText.text = "You have chosen: \n One will land on heads, one will land on tails. \n You will get x2 back from your bet if you are correct.";
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

        if (playerChoice == 1)
        {
            playerFeedbackText.text = "You bet TWO HEADS";
        }
        else if (playerChoice == 2)
        {
            playerFeedbackText.text = "you bet TWO TAILS.";
        }
        else if (playerChoice == 3)
        {
            playerFeedbackText.text = "You bet ONE OF EACH";
        }


    }

    public void ResultsScreen()
    {

        //Debug.Log("Results screen Proc");
        resultsManager.GetComponent<ResultsManager>().Payout();

    }

    public void GamerOverScreen()
    {

        newGameButton.gameObject.SetActive(true);

        bettingValueCanvas.SetActive(false);
        bettingChoicesCanvas.gameObject.SetActive(false);
        flipCoinsCanvas.gameObject.SetActive(false);
        backButton.gameObject.SetActive(false);
        resultsCanvas.SetActive(false);
    }

    public void WinnerScreen()
    {
        resultsCanvas.SetActive(true);
    }

    void Update()
    {
        
    }

}
