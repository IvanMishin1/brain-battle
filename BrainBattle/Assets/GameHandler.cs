using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameHandler : MonoBehaviour
{
    /*
    THIS SCRIPT WAS WRITTEN BY IVAN MISHIN IN JULY-AUGUST 2021

    How this script works:
    1. The game randomly selects where the correct awnser will be,
    2. Then it prepares the buttons,
    3. Then it choses the question and displays it,
    4. Finally the game waits for your awnser and checks it.
    
    THIS SCRIPT WILL BECOME LESS MESSY SOON                                                                        HOPEFULLY!!!
    */

    [Header("Important Variables")]
    public float Score; //Players Score
    public float WinStreak; //Quantity of wins in a row 
    public float RandomPosition; //Variable that holds the random position of the correct awnser
    public float Round; //The quantity of question already awnsered
    public string Lang; //Holds the game's current language 
    public string GameType;//The game type
    public bool timerPause = false;

    [Header("Button Packs")]
    //Button Packs are different combinations of the correct button position
    public GameObject ButtonPack1; //For example: in this button pack the correct awnser is always the top left button 
    public GameObject ButtonPack2;
    public GameObject ButtonPack3;
    public GameObject ButtonPack4;

    [Header("Buttons")]
    public GameObject NextQuestionButton; //Full screen invisible button that is activated after every question. This button generates a new question.
    public GameObject[] Buttons = new GameObject[5];
    [Header("Timer")]
    //GameObjects and Variables in charge of the times
    public float maxTime = 25f;
    public float timeLeft;
    public Image timerBar;

    //FUNCTIONS
    public void Update()
    {
        if(Score < 0) //This if statement makes does so that the score is never less zero
        {
            Score = 0;
        }
        if(timeLeft <= 0f && timerPause == false)
        {
            Lost();
        }
        if(timerPause == false)
        {
        timeLeft -= Time.deltaTime;
        timerBar.fillAmount = timeLeft / maxTime;
        }
    }
    public void Awake()
    {
        
    }
    public void Start() 
    {
        timeLeft = maxTime;
        timerPause = true;
    }
    public void GameStart()
    {
        timerPause = false;
        timeLeft = maxTime;
        Buttons[0].GetComponent<Button>().interactable = true; // Activates all the buttons
        Buttons[1].GetComponent<Button>().interactable = true;
        Buttons[2].GetComponent<Button>().interactable = true;
        Buttons[3].GetComponent<Button>().interactable = true;
        Buttons[4].GetComponent<Button>().interactable = true;
        Buttons[5].GetComponent<Button>().interactable = true;
        Buttons[6].GetComponent<Button>().interactable = true;
        Buttons[7].GetComponent<Button>().interactable = true;
        Buttons[8].GetComponent<Button>().interactable = true;
        Buttons[9].GetComponent<Button>().interactable = true;
        Buttons[10].GetComponent<Button>().interactable = true;
        Buttons[11].GetComponent<Button>().interactable = true;
        Buttons[12].GetComponent<Button>().interactable = true;
        Buttons[13].GetComponent<Button>().interactable = true;
        Buttons[14].GetComponent<Button>().interactable = true;
        Buttons[15].GetComponent<Button>().interactable = true;
        NextQuestionButton.SetActive(false); //Sets to false the NextQuestionButton
        RandomPosition = Random.Range(1,5); //Defines the location of the correct Awnser

        switch(RandomPosition)  
        { // This switch statement deploys the correct button combinations 
        case 1:
            Debug.Log("Setting Position to " + RandomPosition);
            ButtonPack1.SetActive(false);
            ButtonPack1.SetActive(true);
            ButtonPack2.SetActive(false);
            ButtonPack3.SetActive(false);
            ButtonPack4.SetActive(false);
            break;
        case 2:
            Debug.Log("Setting Position to " + RandomPosition);
            ButtonPack2.SetActive(false);
            ButtonPack1.SetActive(false);
            ButtonPack2.SetActive(true);
            ButtonPack3.SetActive(false);
            ButtonPack4.SetActive(false);
            break;
        case 3:
            Debug.Log("Setting Position to " + RandomPosition);
            ButtonPack1.SetActive(false);
            ButtonPack1.SetActive(false);
            ButtonPack2.SetActive(false);
            ButtonPack3.SetActive(true);
            ButtonPack4.SetActive(false);
            break;
        case 4:
            Debug.Log("Setting Position to " + RandomPosition);
            ButtonPack4.SetActive(false);
            ButtonPack1.SetActive(false);
            ButtonPack2.SetActive(false);
            ButtonPack3.SetActive(false);
            ButtonPack4.SetActive(true);
            break;
        }
    }
    public void Won() //Function that is called when the player wins                                  
    {   
        timerPause = true;  
        Debug.Log("You Won!");                                             
        Score = Score + 1;                                 
        WinStreak = WinStreak + 1;                            
        NextQuestionButton.SetActive(true);
        Buttons[0].GetComponent<Button>().interactable = false;
        Buttons[1].GetComponent<Button>().interactable = false;
        Buttons[2].GetComponent<Button>().interactable = false;     //   <---- VERY MESSY CODE
        Buttons[3].GetComponent<Button>().interactable = false;                    
        Buttons[4].GetComponent<Button>().interactable = false;                  
        Buttons[5].GetComponent<Button>().interactable = false;                    
        Buttons[6].GetComponent<Button>().interactable = false;                    
        Buttons[7].GetComponent<Button>().interactable = false;
        Buttons[8].GetComponent<Button>().interactable = false;
        Buttons[9].GetComponent<Button>().interactable = false;
        Buttons[10].GetComponent<Button>().interactable = false;
        Buttons[11].GetComponent<Button>().interactable = false;
        Buttons[12].GetComponent<Button>().interactable = false;
        Buttons[13].GetComponent<Button>().interactable = false;
        Buttons[14].GetComponent<Button>().interactable = false;
        Buttons[15].GetComponent<Button>().interactable = false;  
    }
    public void Lost() //Function that is set when the player loses
    {
        timerPause = true;
        Debug.Log("You Lost!");
        Score = Score - 1;
        WinStreak = 0f;
        NextQuestionButton.SetActive(true);
        Buttons[0].GetComponent<Button>().interactable = false;
        Buttons[1].GetComponent<Button>().interactable = false;
        Buttons[2].GetComponent<Button>().interactable = false;
        Buttons[3].GetComponent<Button>().interactable = false;
        Buttons[4].GetComponent<Button>().interactable = false;
        Buttons[5].GetComponent<Button>().interactable = false;
        Buttons[6].GetComponent<Button>().interactable = false;
        Buttons[7].GetComponent<Button>().interactable = false;
        Buttons[8].GetComponent<Button>().interactable = false;
        Buttons[9].GetComponent<Button>().interactable = false;
        Buttons[10].GetComponent<Button>().interactable = false;
        Buttons[11].GetComponent<Button>().interactable = false;
        Buttons[12].GetComponent<Button>().interactable = false;
        Buttons[13].GetComponent<Button>().interactable = false;
        Buttons[14].GetComponent<Button>().interactable = false;
        Buttons[15].GetComponent<Button>().interactable = false;
    }
}