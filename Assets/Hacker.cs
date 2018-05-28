using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour 
{

    string[] level1Passwords = { "covfefe", "grizzly", "jogging", "zombies", "pumpkin", "cubicle" };
    string[] level2Passwords = { "lumberjack", "chimpanzee", "pickpocket", "blitzkrieg", "technology", "apocalypse" };
    string[] level3Passwords = { "kindheartedness", "acknowledgeable", "procrastination", "differentiation", "consecutiveness", "approximatively" };

    int level;
    enum Screen { MainMenu, Password, Win }
    Screen currentScreen;
    string password;

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
        else if (currentScreen == Screen.Password)
        {
            CheckPassword(input);
        }
    }

    private void RunMainMenu(string input)
    {
        if (input == "1")
        {
            level = 1;
            password = level1Passwords[Random.Range(0, level1Passwords.Length)];
            StartGame();
        }
        else if (input == "2")
        {
            level = 2;
            password = level2Passwords[Random.Range(0, level2Passwords.Length)];
            StartGame();
        }
        else if (input == "3")
        {
            level = 3;
            password = level3Passwords[Random.Range(0, level3Passwords.Length)];
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

    private void CheckPassword(string input)
    {
        if (input == password)
        {
            Terminal.WriteLine("Congratulations! You passed the exam!");
            currentScreen = Screen.Win;
        }
        else
        {
            Terminal.WriteLine("Incorrect. Try again");
            Terminal.WriteLine("Please enter your password:");
        }
    }

    private void StartGame()
    {
        currentScreen = Screen.Password;

        Terminal.ClearScreen();

        Terminal.WriteLine("Please enter your password:");
    }
}
