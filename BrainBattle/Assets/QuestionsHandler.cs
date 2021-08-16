using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestionsHandler : MonoBehaviour
{
    /*
    THIS SCRIPT WAS WRITTEN BY IVAN MISHIN IN JULY-AUGUST 2021

    How this script works:
    1. The Choses a random question by its ID
    2. The script sets the Question Info variables
    3. The 
    */
    [Header("Text Buttons")] 
    public Text CorrectText1;
    public Text CorrectText2;
    public Text CorrectText3;
    public Text CorrectText4;
    public Text IncorrectText1;
    public Text IncorrectText2;
    public Text IncorrectText3;
    public Text IncorrectText4;
    public Text IncorrectText5;
    public Text IncorrectText6;
    public Text IncorrectText7;
    public Text IncorrectText8;
    public Text IncorrectText9;
    public Text IncorrectText10;
    public Text IncorrectText11;
    public Text IncorrectText12;

    [Header("Question Info")]
    public float CurrQuestionID; 
    public string CurrQuestion;
    public string CurrCorrectAwnser1;
    public string CurrAwnser2;
    public string CurrAwnser3;
    public string CurrAwnser4;
    public string CurrCategory;

    public void Start()
    {
        QuestionGenerator();
    }
    public void QuestionGenerator()
    {
        CurrQuestionID = Random.Range(0,31);//
        Debug.Log("QuestionID =" + CurrQuestionID);
        switch(CurrQuestionID)
        {
        case 0:
        CurrQuestion = "TEST0";
        CurrCorrectAwnser1 = "1";
        CurrAwnser2 = "2";
        CurrAwnser3 = "3";
        CurrAwnser4 = "4";
        CurrCategory = "5";
        //Destroy(CorrectButtonTexts1);
        break;
        case 1:
        CurrQuestion = "TEST1";
        CurrCorrectAwnser1 = "1";
        CurrAwnser2 = "2";
        CurrAwnser3 = "3";
        CurrAwnser4 = "4";
        CurrCategory = "5";
        break;
        case 2:
        CurrQuestion = "TEST2";
        CurrCorrectAwnser1 = "1";
        CurrAwnser2 = "2";
        CurrAwnser3 = "3";
        CurrAwnser4 = "4";
        CurrCategory = "5";
        break;
        case 3:
        CurrQuestion = "TEST3";
        CurrCorrectAwnser1 = "1";
        CurrAwnser2 = "2";
        CurrAwnser3 = "3";
        CurrAwnser4 = "4";
        CurrCategory = "5";
        break;
        case 4:
        CurrQuestion = "TEST4";
        CurrCorrectAwnser1 = "1";
        CurrAwnser2 = "2";
        CurrAwnser3 = "3";
        CurrAwnser4 = "4";
        CurrCategory = "5";
        break;
        case 5:
        CurrQuestion = "TEST5";
        CurrCorrectAwnser1 = "1";
        CurrAwnser2 = "2";
        CurrAwnser3 = "3";
        CurrAwnser4 = "4";
        CurrCategory = "5";
        break;
        case 6:
        CurrQuestion = "TEST6";
        CurrCorrectAwnser1 = "1";
        CurrAwnser2 = "2";
        CurrAwnser3 = "3";
        CurrAwnser4 = "4";
        CurrCategory = "5";
        break;
        case 7:
        CurrQuestion = "TEST7";
        CurrCorrectAwnser1 = "1";
        CurrAwnser2 = "2";
        CurrAwnser3 = "3";
        CurrAwnser4 = "4";
        CurrCategory = "5";
        break;
        case 8:
        CurrQuestion = "TEST8";
        CurrCorrectAwnser1 = "1";
        CurrAwnser2 = "2";
        CurrAwnser3 = "3";
        CurrAwnser4 = "4";
        CurrCategory = "5";
        break;
        case 9:
        CurrQuestion = "TEST9";
        CurrCorrectAwnser1 = "1";
        CurrAwnser2 = "2";
        CurrAwnser3 = "3";
        CurrAwnser4 = "4";
        CurrCategory = "5";
        break;
        case 10:
        CurrQuestion = "TEST10";
        CurrCorrectAwnser1 = "1";
        CurrAwnser2 = "2";
        CurrAwnser3 = "3";
        CurrAwnser4 = "4";
        CurrCategory = "5";
        break;
        case 11:
        CurrQuestion = "TEST11";
        CurrCorrectAwnser1 = "1";
        CurrAwnser2 = "2";
        CurrAwnser3 = "3";
        CurrAwnser4 = "4";
        CurrCategory = "5";
        break;
        case 12:
        CurrQuestion = "TEST12";
        CurrCorrectAwnser1 = "1";
        CurrAwnser2 = "2";
        CurrAwnser3 = "3";
        CurrAwnser4 = "4";
        CurrCategory = "5";
        break;
        case 13:
        CurrQuestion = "TEST13";
        CurrCorrectAwnser1 = "1";
        CurrAwnser2 = "2";
        CurrAwnser3 = "3";
        CurrAwnser4 = "4";
        CurrCategory = "5";
        break;
        case 14:
        CurrQuestion = "TEST14";
        CurrCorrectAwnser1 = "1";
        CurrAwnser2 = "2";
        CurrAwnser3 = "3";
        CurrAwnser4 = "4";
        CurrCategory = "5";
        break;
        case 15:
        CurrQuestion = "TEST15";
        CurrCorrectAwnser1 = "1";
        CurrAwnser2 = "2";
        CurrAwnser3 = "3";
        CurrAwnser4 = "4";
        CurrCategory = "5";
        break;
        case 16:
        CurrQuestion = "TEST16";
        CurrCorrectAwnser1 = "1";
        CurrAwnser2 = "2";
        CurrAwnser3 = "3";
        CurrAwnser4 = "4";
        CurrCategory = "5";
        break;
        case 17:
        CurrQuestion = "TEST17";
        CurrCorrectAwnser1 = "1";
        CurrAwnser2 = "2";
        CurrAwnser3 = "3";
        CurrAwnser4 = "4";
        CurrCategory = "5";
        break;
        case 18:
        CurrQuestion = "TEST18";
        CurrCorrectAwnser1 = "1";
        CurrAwnser2 = "2";
        CurrAwnser3 = "3";
        CurrAwnser4 = "4";
        CurrCategory = "5";
        break;
        case 19:
        CurrQuestion = "TEST19";
        CurrCorrectAwnser1 = "1";
        CurrAwnser2 = "2";
        CurrAwnser3 = "3";
        CurrAwnser4 = "4";
        CurrCategory = "5";
        break;
        case 20:
        CurrQuestion = "TEST20";
        CurrCorrectAwnser1 = "1";
        CurrAwnser2 = "2";
        CurrAwnser3 = "3";
        CurrAwnser4 = "4";
        CurrCategory = "5";
        break;
        case 21:
        CurrQuestion = "TEST21";
        CurrCorrectAwnser1 = "1";
        CurrAwnser2 = "2";
        CurrAwnser3 = "3";
        CurrAwnser4 = "4";
        CurrCategory = "5";
        break;
        case 22:
        CurrQuestion = "TEST22";
        CurrCorrectAwnser1 = "1";
        CurrAwnser2 = "2";
        CurrAwnser3 = "3";
        CurrAwnser4 = "4";
        CurrCategory = "5";
        break;
        case 23:
        CurrQuestion = "TEST23";
        CurrCorrectAwnser1 = "1";
        CurrAwnser2 = "2";
        CurrAwnser3 = "3";
        CurrAwnser4 = "4";
        CurrCategory = "5";
        break;
        case 24:
        CurrQuestion = "TEST24";
        CurrCorrectAwnser1 = "1";
        CurrAwnser2 = "2";
        CurrAwnser3 = "3";
        CurrAwnser4 = "4";
        CurrCategory = "5";
        break;
        case 25:
        CurrQuestion = "TEST25";
        CurrCorrectAwnser1 = "1";
        CurrAwnser2 = "2";
        CurrAwnser3 = "3";
        CurrAwnser4 = "4";
        CurrCategory = "5";
        break;
        case 26:
        CurrQuestion = "TEST26";
        CurrCorrectAwnser1 = "1";
        CurrAwnser2 = "2";
        CurrAwnser3 = "3";
        CurrAwnser4 = "4";
        CurrCategory = "5";
        break;
        case 27:
        CurrQuestion = "TEST27";
        CurrCorrectAwnser1 = "1";
        CurrAwnser2 = "2";
        CurrAwnser3 = "3";
        CurrAwnser4 = "4";
        CurrCategory = "5";
        break;
        case 28:
        CurrQuestion = "TEST28";
        CurrCorrectAwnser1 = "1";
        CurrAwnser2 = "2";
        CurrAwnser3 = "3";
        CurrAwnser4 = "4";
        CurrCategory = "5";
        break;
        case 29:
        CurrQuestion = "TEST29";
        CurrCorrectAwnser1 = "1";
        CurrAwnser2 = "2";
        CurrAwnser3 = "3";
        CurrAwnser4 = "4";
        CurrCategory = "5";
        break;
        case 30:
        CurrQuestion = "TEST30";
        CurrCorrectAwnser1 = "1";
        CurrAwnser2 = "2";
        CurrAwnser3 = "3";
        CurrAwnser4 = "4";
        CurrCategory = "5";
        break;
        }
        /*CorrectText1.text = CurrCorrectAwnser1 ="2";
        CorrectText2.text = CurrCorrectAwnser2 ="0";
        CorrectText3.text = CurrCorrectAwnser3 ="0";
        CorrectText4.text = CurrCorrectAwnser4 ="0";
        */
    }
}
