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
    [Header("Text Objects")] 
    public GameObject Text0; //Question
    public GameObject Text1; //Awnser  
    public GameObject Text2; //Awnser
    public GameObject Text3;
    public GameObject Text4;
    public GameObject Text5;
    public GameObject Text6;
    public GameObject Text7;
    public GameObject Text8;
    public GameObject Text9; //         <---- MORE AWNSERS
    public GameObject Text10;
    public GameObject Text11;
    public GameObject Text12;
    public GameObject Text13;
    public GameObject Text14;
    public GameObject Text15;
    public GameObject Text16;

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
        CurrQuestionID = Random.Range(0,4);
        Debug.Log("QuestionID =" + CurrQuestionID);
        switch(CurrQuestionID)
        {
        case 0:
        CurrQuestion = "Witch city from the list has the largest population?";
        CurrCorrectAwnser1 = "Moscow";
        CurrAwnser2 = "Washington";
        CurrAwnser3 = "Paris";
        CurrAwnser4 = "Hamburg";
        CurrCategory = "Geo";
        break;
        case 1:
        CurrQuestion = "In whitch year was McDonalds created?";
        CurrCorrectAwnser1 = "1955";
        CurrAwnser2 = "1939";
        CurrAwnser3 = "1964";
        CurrAwnser4 = "1959";
        CurrCategory = "Food";
        break;
        case 2:
        CurrQuestion = "What is the capital of New Zealand?";
        CurrCorrectAwnser1 = "Wellington";
        CurrAwnser2 = "Sydney";
        CurrAwnser3 = "Auckland";
        CurrAwnser4 = "Capetown";
        CurrCategory = "Geo";
        break;
        case 3:
        CurrQuestion = "How many calories does a regular Big Mac contain?";
        CurrCorrectAwnser1 = "500-600";
        CurrAwnser2 = "400-500";
        CurrAwnser3 = "600-700";
        CurrAwnser4 = "300-400";
        CurrCategory = "Food";
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
        Text0.GetComponent<UnityEngine.UI.Text>().text = CurrQuestion.ToString();

        Text1.GetComponent<UnityEngine.UI.Text>().text = CurrCorrectAwnser1.ToString();
        Text2.GetComponent<UnityEngine.UI.Text>().text = CurrAwnser2.ToString();
        Text3.GetComponent<UnityEngine.UI.Text>().text = CurrAwnser3.ToString();
        Text4.GetComponent<UnityEngine.UI.Text>().text = CurrAwnser4.ToString();

        Text5.GetComponent<UnityEngine.UI.Text>().text = CurrAwnser2.ToString();
        Text6.GetComponent<UnityEngine.UI.Text>().text = CurrCorrectAwnser1.ToString();
        Text7.GetComponent<UnityEngine.UI.Text>().text = CurrAwnser4.ToString();
        Text8.GetComponent<UnityEngine.UI.Text>().text = CurrAwnser3.ToString();

        Text9.GetComponent<UnityEngine.UI.Text>().text = CurrAwnser3.ToString();
        Text10.GetComponent<UnityEngine.UI.Text>().text = CurrAwnser4.ToString();
        Text11.GetComponent<UnityEngine.UI.Text>().text = CurrCorrectAwnser1.ToString();
        Text12.GetComponent<UnityEngine.UI.Text>().text = CurrAwnser2.ToString();

        Text13.GetComponent<UnityEngine.UI.Text>().text = CurrAwnser4.ToString();
        Text14.GetComponent<UnityEngine.UI.Text>().text = CurrAwnser3.ToString();
        Text15.GetComponent<UnityEngine.UI.Text>().text = CurrAwnser2.ToString();
        Text16.GetComponent<UnityEngine.UI.Text>().text = CurrCorrectAwnser1.ToString();
    }
}
