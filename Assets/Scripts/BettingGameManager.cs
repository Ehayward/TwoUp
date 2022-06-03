using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BettingGameManager : MonoBehaviour
{
    //variable names
    private int playerCashStack;
    private int playerChoice;
    private int coinResults;

    //Text names
    public Text cashStackAmount;
    public Text playerFeedbackText;

    //Button names
    public Button bothTailsButton;
    public Button bothHeadsButton;
    public Button oneOfEachButton;
    public Button backButton;
    public Button lockInAndFlipButton;
    public Button increaseBetButton;
    public Button decreaseBetButton;

    //Canvas names
    public GameObject bettingChoicesCanvas;
    public GameObject flipCoinsandResultsCanvas;

    //Camera names
    public GameObject Coin1;
    public GameObject Coin2;
    public GameObject thirdPersonCamera;
    public GameObject mainMenuCamera;

    //Group Objects
    public GameObject threeBettingButtons;


    void Start()
    {
        NewGame();
    }

    private void NewGame()
    {
        //setting variable values
        playerCashStack = 25;

        //selecting canvas and camera
        flipCoinsandResultsCanvas.gameObject.SetActive(false);
        Coin1.gameObject.SetActive(false);
        Coin2.gameObject.SetActive(false);
        thirdPersonCamera.SetActive(false);

        bettingChoicesCanvas.gameObject.SetActive(true);
        mainMenuCamera.SetActive(true);
        threeBettingButtons.gameObject.SetActive(true);
               
        playerFeedbackText.text = "Welcome to Two-Up!\n What result do you think the coins will land on?";

    }

    private void BetAgain()
    {
        //selecting canvas and camera
        flipCoinsandResultsCanvas.gameObject.SetActive(false);
        Coin1.gameObject.SetActive(false);
        Coin2.gameObject.SetActive(false);
        thirdPersonCamera.SetActive(false);

        bettingChoicesCanvas.gameObject.SetActive(true);
        mainMenuCamera.SetActive(true);
        threeBettingButtons.gameObject.SetActive(true);

        playerFeedbackText.text = "Welcome back, how about another bet!\n What result do you think the coins will land on?";

    }

    void Update()
    {
        
    }
}
