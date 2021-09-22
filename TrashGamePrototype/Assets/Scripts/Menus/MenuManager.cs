using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Manages all the menus
/// </summary>
public class MenuManager : MonoBehaviour
{
    //Reference to the two menus
    public GameObject SettingsMenu;
    public GameObject PauseMenu;

    private void Start()
    {
        SettingsMenu.SetActive(false);
        PauseMenu.SetActive(false);
    }

    //Closes the game
    public void QuitGame()
    {
        Application.Quit();
    }

    //Opens the pause menu
    public void OpenPauseMenu()
    {
        PauseMenu.SetActive(true);
    }

    //Closes the pause menu
    public void ClosePauseMenu()
    {
        PauseMenu.SetActive(false);
    }

    //Opens the settings menu
    public void OpenSettingsMenu()
    {
        SettingsMenu.SetActive(true);
        PauseMenu.SetActive(false);
    }

    //Closes the settings 
    public void CloseSettingsMenu()
    {
        PauseMenu.SetActive(true);
        SettingsMenu.SetActive(false);
    }

    public void ChangeMusicVolume()
    {

    }

    public void ChangeAudioVolume()
    {

    }

}