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
    2. When a menu button gets pressed, the script activates(and disactivates certain UI elements).
    */
    [Header("Menu Objects")]
    public GameObject Menu;
    public GameObject Game;
    public GameObject Account;
    public GameObject Settings;

    [Header("Settings Objects")]
    public Button EnglishButton;
    public Button FrenchButton;
    public Button RussianButton;

    //MAIN MENU AND BACK
    public void PlayButtonClick()
    {
        Menu.SetActive(false);
        Game.SetActive(true);
        Account.SetActive(false);
        Settings.SetActive(false);
    }
    public void AccountButtonClick()
    {
        Menu.SetActive(false);
        Game.SetActive(false);
        Account.SetActive(true);
        Settings.SetActive(false);
    }
    public void SettingsButtonClick()
    {
        Menu.SetActive(false);
        Game.SetActive(false);
        Account.SetActive(false);
        Settings.SetActive(true);
    }
    public void BackToMenuClick()
    {
        Menu.SetActive(true);
        Game.SetActive(false);
        Account.SetActive(false);
        Settings.SetActive(false);
    }
    //SETTINGS
    public void ToggleEnglish()
    {
        EnglishButton.interactable = false;
        FrenchButton.interactable = true;
        RussianButton.interactable = true;
    }
    public void ToggleFrench()
    {
        EnglishButton.interactable = true;
        FrenchButton.interactable = false;
        RussianButton.interactable = true;
    }
    public void ToggleRussian()
    {
        EnglishButton.interactable = true;
        FrenchButton.interactable = true;
        RussianButton.interactable = false;
    }

}
