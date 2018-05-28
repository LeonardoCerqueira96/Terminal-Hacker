using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour 
{
    int level;

    enum Screen { MainMenu, Password, Win }
    Screen currentScreen;

	// Use this for initialization
	void Start() 
	{
        ShowMainMenu();
        Terminal.WriteLine("Enter your selection: ");
    }

    private void ShowMainMenu()
    {
        currentScreen = Screen.MainMenu;

        Terminal.ClearScreen();

        Terminal.WriteLine("Welcome to the Anonymous entrance exam");
        Terminal.WriteLine("Select below your entrance level\n");

        Terminal.WriteLine("Press 1 for the Initiate level exam");
        Terminal.WriteLine("Press 2 for the Mid level exam");
        Terminal.WriteLine("Press 3 for the Expert level exam\n");
    }

    private void OnUserInput(string input)
    {
        if (input == "menu")
        {
            ShowMainMenu();
        }
        else if (currentScreen == Screen.MainMenu)
        {
            RunMainMenu(input);
        }
    }

    private void RunMainMenu(string input)
    {
        if (input == "1")
        {
            level = 1;
            StartGame();
        }
        else if (input == "2")
        {
            level = 2;
            StartGame();
        }
        else if (input == "3")
        {
            level = 3;
            StartGame();
        }
        else if (input == "420")
        {
            Terminal.WriteLine("You can do that later");
            Terminal.WriteLine("Enter your selection: ");
        }
        else if (input == "007")
        {
            Terminal.WriteLine("It's an honor, Mr. Bond");
            Terminal.WriteLine("Enter your selection: ");
        }
        else
        {
            Terminal.WriteLine("Please enter valid input");
            Terminal.WriteLine("Enter your selection: ");
        }
    }

    private void StartGame()
    {
        currentScreen = Screen.Password;
        Terminal.WriteLine("Level " + level + " loaded");
        Terminal.WriteLine("Please enter your password:");
    }
}
