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
        //QuestionGenerator();
    }
    public void QuestionGenerator()
    {
        CurrQuestionID = Random.Range(0,10);
        Debug.Log("QuestionID = " + CurrQuestionID);
        switch(CurrQuestionID)
        {

        // ENGLISH QUESTIONS

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
        CurrQuestion = "Which Italian city is credited as the birthplace of the pizza?";
        CurrCorrectAwnser1 = "Neaples";
        CurrAwnser2 = "Rome";
        CurrAwnser3 = "Piza";
        CurrAwnser4 = "Bergamo";
        CurrCategory = "Food";
        break;
        case 5:
        CurrQuestion = "How many keys are there on a piano?";
        CurrCorrectAwnser1 = "88";
        CurrAwnser2 = "60";
        CurrAwnser3 = "100";
        CurrAwnser4 = "90";
        CurrCategory = "Art";
        break;
        case 6:
        CurrQuestion = "Who Won the MVP award 2001 (NBA)";
        CurrCorrectAwnser1 = "Allen Iverson";
        CurrAwnser2 = "Chris Paul";
        CurrAwnser3 = "Shaquille O'Neal";
        CurrAwnser4 = "Scottie Pippen";
        CurrCategory = "Sports";
        break;
        case 7:
        CurrQuestion = "Witch one of these people was one of the founding fathers of America";
        CurrCorrectAwnser1 = "John ADAMS";
        CurrAwnser2 = "Steve PAUL";
        CurrAwnser3 = "Peter ABRAHAM";
        CurrAwnser4 = "Nicola DONCIKE";
        CurrCategory = "History";
        break;
        case 8:
        CurrQuestion = "Name two Double Land Locked countries";
        CurrCorrectAwnser1 = "Liechtenstein and Uzbekistan";
        CurrAwnser2 = "South Sudan and North Sudan";
        CurrAwnser3 = "Wyoming and Arkansas";
        CurrAwnser4 = "Saarland and Cuba";
        CurrCategory = "Geography";
        break;
        case 9:
        CurrQuestion = "Who is Steph CURRY?";
        CurrCorrectAwnser1 = "NBA player";
        CurrAwnser2 = "Golf player";
        CurrAwnser3 = "5 star chef in France";
        CurrAwnser4 = "Table tennis player";
        CurrCategory = "Sports";
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

        // RUSSIAN QUESTIONS

        case 25:
        CurrQuestion = "?? ?????????? ???????? ???????????? ???????????????????? ????????????????,";
        CurrCorrectAwnser1 = "?? ????????????????";
        CurrAwnser2 = "?? ??????????????";
        CurrAwnser3 = "?? ??????????????????????";
        CurrAwnser4 = "?? ??????????????";
        CurrCategory = "Science";
        break;
        case 26:
        CurrQuestion = "?????????? ?????? ???????????????? ?????????? ?????????????";
        CurrCorrectAwnser1 = "??????????????";
        CurrAwnser2 = "??????????";
        CurrAwnser3 = "????????????";
        CurrAwnser4 = "????????????????";
        CurrCategory = "Science";
        break;
        case 27:
        CurrQuestion = "?????? ???????????????? ?????????????? ???????????? ?????????????????? ?? ?????";
        CurrCorrectAwnser1 = "??????????????";
        CurrAwnser2 = "??????????????????";
        CurrAwnser3 = "????????????????";
        CurrAwnser4 = "??????????????";
        CurrCategory = "Geography";
        break;
        case 28:
        CurrQuestion = "?????????? ?????????????? ?? ???????? ???????????????? ?????????? ???????????????";
        CurrCorrectAwnser1 = "????????????";
        CurrAwnser2 = "????????????????";
        CurrAwnser3 = "????????????";
        CurrAwnser4 = "?????????????? ????????";
        CurrCategory = "Geography";
        break;
        case 29:
        CurrQuestion = "?????????????? ?????? ???????????????? ???? ???????? ?????????????????? ???????????????? ???????? ???????????????";
        CurrCorrectAwnser1 = "30 ?????? ?? 3 ????????";
        CurrAwnser2 = "44 ???????? ?? 8 ????????";
        CurrAwnser3 = "30 ????????????";
        CurrAwnser4 = "7 ?????????? ?? 30 ????????????";
        CurrCategory = "Literature";
        break;
        case 30:
        CurrQuestion = "???????????? ????????????????????????????? ???? ?????????? ???????? ?????????? ????????????. ???????????????? ?????? ??????.";
        CurrCorrectAwnser1 = "???????????????? ???????????????? ????????";
        CurrAwnser2 = "?????????????????? ?????????????????? ????????????";
        CurrAwnser3 = "???????????? ?????????????? ??????????????????";
        CurrAwnser4 = "???????????? ?????????????????????????? ????????????";
        CurrCategory = "Literature";
        break;
        case 31:
        CurrQuestion = "TEST30";
        CurrCorrectAwnser1 = "1";
        CurrAwnser2 = "2";
        CurrAwnser3 = "3";
        CurrAwnser4 = "4";
        CurrCategory = "5";
        break;
        case 32:
        CurrQuestion = "TEST30";
        CurrCorrectAwnser1 = "1";
        CurrAwnser2 = "2";
        CurrAwnser3 = "3";
        CurrAwnser4 = "4";
        CurrCategory = "5";
        break;
        case 33:
        CurrQuestion = "TEST30";
        CurrCorrectAwnser1 = "1";
        CurrAwnser2 = "2";
        CurrAwnser3 = "3";
        CurrAwnser4 = "4";
        CurrCategory = "5";
        break;
        case 34:
        CurrQuestion = "TEST30";
        CurrCorrectAwnser1 = "1";
        CurrAwnser2 = "2";
        CurrAwnser3 = "3";
        CurrAwnser4 = "4";
        CurrCategory = "5";
        break;
        case 35:
        CurrQuestion = "TEST30";
        CurrCorrectAwnser1 = "1";
        CurrAwnser2 = "2";
        CurrAwnser3 = "3";
        CurrAwnser4 = "4";
        CurrCategory = "5";
        break;
        case 36:
        CurrQuestion = "TEST30";
        CurrCorrectAwnser1 = "1";
        CurrAwnser2 = "2";
        CurrAwnser3 = "3";
        CurrAwnser4 = "4";
        CurrCategory = "5";
        break;
        case 37:
        CurrQuestion = "TEST30";
        CurrCorrectAwnser1 = "1";
        CurrAwnser2 = "2";
        CurrAwnser3 = "3";
        CurrAwnser4 = "4";
        CurrCategory = "5";
        break;
        case 38:
        CurrQuestion = "TEST30";
        CurrCorrectAwnser1 = "1";
        CurrAwnser2 = "2";
        CurrAwnser3 = "3";
        CurrAwnser4 = "4";
        CurrCategory = "5";
        break;
        case 39:
        CurrQuestion = "TEST30";
        CurrCorrectAwnser1 = "1";
        CurrAwnser2 = "2";
        CurrAwnser3 = "3";
        CurrAwnser4 = "4";
        CurrCategory = "5";
        break;
        case 40:
        CurrQuestion = "TEST30";
        CurrCorrectAwnser1 = "1";
        CurrAwnser2 = "2";
        CurrAwnser3 = "3";
        CurrAwnser4 = "4";
        CurrCategory = "5";
        break;
        case 41:
        CurrQuestion = "TEST30";
        CurrCorrectAwnser1 = "1";
        CurrAwnser2 = "2";
        CurrAwnser3 = "3";
        CurrAwnser4 = "4";
        CurrCategory = "5";
        break;
        case 42:
        CurrQuestion = "TEST30";
        CurrCorrectAwnser1 = "1";
        CurrAwnser2 = "2";
        CurrAwnser3 = "3";
        CurrAwnser4 = "4";
        CurrCategory = "5";
        break;
        case 43:
        CurrQuestion = "TEST30";
        CurrCorrectAwnser1 = "1";
        CurrAwnser2 = "2";
        CurrAwnser3 = "3";
        CurrAwnser4 = "4";
        CurrCategory = "5";
        break;
        case 44:
        CurrQuestion = "TEST30";
        CurrCorrectAwnser1 = "1";
        CurrAwnser2 = "2";
        CurrAwnser3 = "3";
        CurrAwnser4 = "4";
        CurrCategory = "5";
        break;
        case 45:
        CurrQuestion = "TEST30";
        CurrCorrectAwnser1 = "1";
        CurrAwnser2 = "2";
        CurrAwnser3 = "3";
        CurrAwnser4 = "4";
        CurrCategory = "5";
        break;
        case 46:
        CurrQuestion = "TEST30";
        CurrCorrectAwnser1 = "1";
        CurrAwnser2 = "2";
        CurrAwnser3 = "3";
        CurrAwnser4 = "4";
        CurrCategory = "5";
        break;
        case 47:
        CurrQuestion = "TEST30";
        CurrCorrectAwnser1 = "1";
        CurrAwnser2 = "2";
        CurrAwnser3 = "3";
        CurrAwnser4 = "4";
        CurrCategory = "5";
        break;
        case 48:
        CurrQuestion = "TEST30";
        CurrCorrectAwnser1 = "1";
        CurrAwnser2 = "2";
        CurrAwnser3 = "3";
        CurrAwnser4 = "4";
        CurrCategory = "5";
        break;
        case 49:
        CurrQuestion = "TEST30";
        CurrCorrectAwnser1 = "1";
        CurrAwnser2 = "2";
        CurrAwnser3 = "3";
        CurrAwnser4 = "4";
        CurrCategory = "5";
        break;
        case 50:
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
