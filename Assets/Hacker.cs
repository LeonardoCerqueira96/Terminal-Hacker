using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour 
{

	// Use this for initialization
	void Start() 
	{
        ShowMainMenu("Hello Nagi");
    }

    private void ShowMainMenu(string greeting)
    {
        Terminal.ClearScreen();

        Terminal.WriteLine(greeting);

        Terminal.WriteLine("Welcome to the Anonymous entrance exam");
        Terminal.WriteLine("Select below your entrance level\n");

        Terminal.WriteLine("Press 1 for the Initiate level exam");
        Terminal.WriteLine("Press 2 for the Mid level exam");
        Terminal.WriteLine("Press 3 for the Expert level exam\n");

        Terminal.WriteLine("Enter your selection: ");
    }

    private void OnUserInput(string input)
    {
        Debug.Log("User typed " + input);
    }
}
