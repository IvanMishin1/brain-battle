using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Analitics : MonoBehaviour
{
    public float CorrectQuestionsIndex; //A decimal value of the percentage of Correct Questions
    public float IncorrectQuestionsIndex;
    public GameHandler gameHandler;

    //STATS PAGE
    public Image BarChartCorrect;
    public Image BarChartIncorrect;

    // Start is called before the first frame update
    void Start()
    {
        gameHandler = FindObjectOfType<GameHandler>();
    }

    // Update is called once per frame
    void Update()
    {
        //GENERAL CALCULATIONS
        IncorrectQuestionsIndex = gameHandler.TimesLost / (gameHandler.TimesWon + gameHandler.TimesLost);
        CorrectQuestionsIndex = gameHandler.TimesWon / (gameHandler.TimesWon + gameHandler.TimesLost);

        //VISUAL BAR CHART
        if(CorrectQuestionsIndex > 0)
        {
        BarChartIncorrect.fillAmount = IncorrectQuestionsIndex;
        BarChartCorrect.fillAmount = CorrectQuestionsIndex;
        }
        else
        {
        BarChartIncorrect.fillAmount = 0.5f;
        BarChartCorrect.fillAmount = 0.5f;
        }
    }
}
