using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BettingGameManager : MonoBehaviour
{
    private int playerCashStack;
    private int playerChoice;
    private int coinResults;

    public Text cashStackAmount;
    public Text playerFeedbackText;

    public Button bothTailsButton;
    public Button bothHeadsButton;
    public Button oneOfEachButton;
    public Button backButton;
    public Button lockInAndFlipButton;
    public Button increaseBetButton;
    public Button decreaseBetButton;

    public GameObject bettingChoicesCanvas;
    public GameObject flipCoinsandResultsCanvas;

    void Start()
    {
        NewGame();
    }

    private void NewGame()
    {
        playerCashStack = 25;
        playerChoice = 0;

        flipCoinsandResultsCanvas.gameObject.SetActive(false);
        bettingChoicesCanvas.gameObject.SetActive(true);
        
        playerFeedbackText.text = "Welcome to Two-Up! What result do you think the coins will land on?";



    }

    void Update()
    {
        
    }
}
