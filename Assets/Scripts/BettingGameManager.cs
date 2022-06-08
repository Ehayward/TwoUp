using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BettingGameManager : MonoBehaviour
{
    //variable names
    private int playerCashStack;
    private int playerChoice;
    private int betValue;
    private int coinResults;

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
    public GameObject flipCoinsandResultsCanvas;
    public GameObject bettingValueCanvas;

    //Camera names
    public GameObject Coin1;
    public GameObject Coin2;
    public GameObject thirdPersonCamera;
    public GameObject mainMenuCamera;


    //Group Objects / buttons
    public GameObject threeBettingButtons;
    public GameObject flipButton;
    public GameObject backButton;


    void Start()
    {
        NewGame();
    }

    private void NewGame()
    {
        //setting variable values
        playerCashStack = 25;
        playerChoice = 0;
        cashStackAmount.text = "$" + playerCashStack;

        //selecting canvas and camera
        flipCoinsandResultsCanvas.gameObject.SetActive(false);
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
        cashStackAmount.text = "$" + playerCashStack;
        playerChoice = 0;

        //selecting canvas and camera
        flipCoinsandResultsCanvas.gameObject.SetActive(false);
        bettingChoicesCanvas.gameObject.SetActive(false);
        Coin1.gameObject.SetActive(false);
        Coin2.gameObject.SetActive(false);
        thirdPersonCamera.SetActive(false);
        bettingValueCanvas.SetActive(false);
        backButton.gameObject.SetActive(false);

        bettingChoicesCanvas.gameObject.SetActive(true);
        mainMenuCamera.SetActive(true);
        threeBettingButtons.gameObject.SetActive(true);
        flipButton.gameObject.SetActive(true);

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
        flipCoinsandResultsCanvas.gameObject.SetActive(true);
        Coin1.gameObject.SetActive(true);
        Coin2.gameObject.SetActive(true);
        thirdPersonCamera.SetActive(true);
        backButton.gameObject.SetActive(false);


        bettingValueCanvas.SetActive(false);
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

    }



    void Update()
    {
        
    }
}
