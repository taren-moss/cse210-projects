using System;

public class Entry
{
    public string _getDate = "";
    public string _sortedPrompt = "";
    public string _saveInput = "";

    public void AddDate()
    {
        DateTime now = DateTime.Now;
        string currentDate = now.ToShortDateString();
        string currentTime = now.ToShortTimeString();
        string currentDateAndTime = $"{currentDate} at {currentTime}:";
        _getDate = currentDateAndTime;
    }

    public void RandomPrompt()
    {
        // Got some ideas for how to do this from https://www.tutorialspoint.com/how-to-select-a-random-element-from-a-chash-list
        // I did't copy it exactly (it actually didn't work without modification)

        string[] prompts = System.IO.File.ReadAllLines("Prompts.txt"); // I decided to put the prompts in a text file for easy editing
        Random random = new Random();
        int randomPromptIndex = random.Next((prompts.Length) - 1); // Index starts at 0, so subtract 1
        _sortedPrompt = prompts[randomPromptIndex]; // This returns one prompt from the list
        Console.WriteLine(_sortedPrompt);
    }

    public void RecordInput()
    {
        AddDate();
        RandomPrompt();
        string userInput = Console.ReadLine();
        _saveInput = userInput;
    }
}