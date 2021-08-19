using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuHandler : MonoBehaviour
{
    /*
    THIS SCRIPT WAS WRITTEN BY IVAN MISHIN IN JULY-AUGUST 2021

    How this script works:
    1. The Script waits for some input on the menu buttons
    2. When a menu button gets pressed, the script activates(and disactivates certain parts of the script).
    */
    [Header("Menu Objects")]
    public GameObject Menu;
    public GameObject Game;
    public GameObject Settings;

    public void PlayButtonClick()
    {
        Menu.SetActive(false);
        Game.SetActive(true);
    }
    public void SettingsButtonClick()
    {
        Menu.SetActive(false);
        Settings.SetActive(true);
    }
    public void ExitButtonClick()
    {
        Application.Quit();
    }
}
