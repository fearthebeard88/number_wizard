using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour {

    int max = 1000;
    int min = 1;
    int guess = 500;

    // Use this for initialization, think of a constructor function that Unity will always fire off if it exists
    void Start ()
    {
        StartGameDialogue();
	}

    // The void keyword in front of the method definition is the expected return value, so if nothing is returned, its type is null
    void StartGameDialogue()
    {
        Debug.Log("Welcome mortal!  Here at the Number Wizard we will perform fantastic feats of divination to read your mind.");
        Debug.Log("Time for the magic!  Pick a number, but don't tell me what it is.  I will divine it from your mind...");
        Debug.Log("The highest number you can pick is " + this.max + ", ");
        Debug.Log("The lowest number you can pick is " + this.min + ".");
        Debug.Log("Tell me if your number is higher or lower than my guess!  Current Guess: " + this.guess);
        Debug.Log("Press the Up arrow if our current guess is too high, press the Down arrow if it's too low.  If we guessed your number, press Enter.");
        this.max = this.max + 1;
    }

    void RestartGame()
    {
        this.min = 1;
        this.max = 1000;
        this.guess = 500;

        StartGameDialogue();
    }

    void NextGuess()
    {
        int min = this.min;
        int max = this.max;

        this.guess = (max + min) / 2;

        Debug.Log("Is this your number?" + this.guess);
    }
	
	// Update is called once per frame, basically instant reaction
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            this.min = this.guess;
            NextGuess();
        }

        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            this.max = this.guess;
            NextGuess();
        }

        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("AHA!  Totally guessed your number...Wait!  I mean We have successfully divined the number from your brain mortal.  Now bow down and pay homage to our greatness!");
            RestartGame();
        }

    }
    // to comment lines of code, highlight and press ctl + k + c
    //if (!Input.GetKeyDown(KeyCode.DownArrow) || !Input.GetKeyDown(KeyCode.UpArrow) || !Input.GetKeyDown(KeyCode.Return))
    //    {
    //        Debug.Log("You have pressed an invalid key, please use the up or down arrows or the enter/return key...");
    //    }
}
