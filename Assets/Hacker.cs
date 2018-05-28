using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour 
{
    List<string> availableLevels = new List<string>{ "1", "2", "3" };
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

        Terminal.WriteLine("Enter your selection: ");
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
        if (availableLevels.Contains(input))
        {
            level = int.Parse(input);
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

        switch(level)
        {
            case 1:
                password = level1Passwords[Random.Range(0, level1Passwords.Length)];
                break;
            case 2:
                password = level2Passwords[Random.Range(0, level2Passwords.Length)];
                break;
            case 3:
                password = level3Passwords[Random.Range(0, level3Passwords.Length)];
                break;
            default:
                Debug.LogError("Invalid level number");
                break;
        }

        Terminal.ClearScreen();

        Terminal.WriteLine("Enter your password, hint: " + password.Anagram());
    }

    private void CheckPassword(string input)
    {
        if (input == password)
        {
            DisplayWinScreen();
        }
        else
        {
            Terminal.WriteLine("Incorrect. Try again");
            Terminal.WriteLine("Enter your password, hint: " + password.Anagram());
        }
    }

    private void DisplayWinScreen()
    {
        currentScreen = Screen.Win;

        Terminal.ClearScreen();
        Terminal.WriteLine("Congratulations! You passed the exam!");
        ShowLevelReward();
    }

    private void ShowLevelReward()
    {
        switch (level)
        {
            case 1:
                Terminal.WriteLine(@"

                Rookie
        ─────█─▄▀█──█▀▄─█─────
        ────▐▌──────────▐▌────
        ────█▌▀▄──▄▄──▄▀▐█────
        ───▐██──▀▀──▀▀──██▌───
        ──▄████▄──▐▌──▄████▄──"               
                );
                break;
            case 2:
                Terminal.WriteLine(@"

                Junior
        ─────█─▄▀█──█▀▄─█─────
        ────▐▌──────────▐▌────
        ────█▌▀▄──▄▄──▄▀▐█────
        ───▐██──▀▀──▀▀──██▌───
        ──▄████▄──▐▌──▄████▄──"
                );
                break;
            case 3:
                Terminal.WriteLine(@"

                Master
        ─────█─▄▀█──█▀▄─█─────
        ────▐▌──────────▐▌────
        ────█▌▀▄──▄▄──▄▀▐█────
        ───▐██──▀▀──▀▀──██▌───
        ──▄████▄──▐▌──▄████▄──"
                );
                break;
            default:
                Debug.LogError("Invalid level number");
                break;
        }
    }
}
