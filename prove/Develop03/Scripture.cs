public class Scripture
{
    private Reference _reference = new Reference();
    private List<Word> _scripture = new List<Word>();
    private string verseInfo = "";

    public Scripture() // Default constructor
    {
        _reference = new Reference(); // The Scripture Object uses a Reference Object in a variable
        _scripture = _reference.MakeWordList(); // It uses this Reference Object to generate the other variables
        verseInfo = _reference.AssembleVerseInfo();
    }

    public void PrintText() // Prints the text after assembling it from the Reference object
    {
        Console.Clear(); // Clears the console
        Console.WriteLine(_reference.AssembleVerseInfo()); // Writes the verse info (ex: Jacob 6: 11-13)
        foreach (Word word in _scripture)
        {
            Console.Write($"{word.GetWord()} "); // Writes each word and then adds a space. No new lines.
            // This writes the _word variable in the Word Object. If a word has been hidden, its original word has been replaced
            // with underscores. So this isn't actually as complicated as it sounds. It's doing the same thing whether a word is hidden
            // or not, just the data of the word itself is different if it's been hidden already.
        }
    }

    public void HideWords() // Randomly selects 3 words and runs the Word Object's Hide() function.
    {
        List<Word> unhiddenWords = new List<Word>(); // The code broke when all text was hidden, so I needed to find another way.
        foreach (Word value in _scripture) // This counts how many words are not hidden and makes a list of them
        {
            if (value.CheckStatus() == false)
            {
                unhiddenWords.Add(value); // This list is used for the rest of the code in this function
            }
        }

        Random randomWord = new Random(); // Random stuff
        int countingNumber = 0; // Just a functional variable to count how many times it looped

        while (countingNumber < 3)
        {
            if (unhiddenWords.Count == 0) // The code checks to make sure there's word to hide. If not, end the loop
            {
                countingNumber = 3; // Loop ends when countingNumber is 3 or more. Setting to 3 ends the loop instantly
            }
            else if (unhiddenWords.Count <= 3) // The code checks if there's 3 or less words to hide. Doesn't use random in this case
            {
                foreach (Word item in unhiddenWords) // Checks the Word Objects in the list
                {
                    item.Hide(); // Runs that object's Hide() function
                }
                countingNumber = 3;
            }
            else // If there's 4 or more words, it randomly selects 3
            {
                int wordIndex = randomWord.Next(unhiddenWords.Count - 1); // Random number can only be in the range of the list's length
                Word word = unhiddenWords[wordIndex]; // Selects a random number and uses it as an index
                if (word.CheckStatus() != true)
                {
                    word.Hide();
                    countingNumber += 1;
                }
            }
        }
    }

    public bool HiddenStatus() // Checks if every word is hidden. If they all are, return true.
    {
        bool output = false;

        List<Word> words = new List<Word>(); // Makes a new list
        foreach (Word value in _scripture)
        {
            if (value.CheckStatus() == false) // Only adds unhidden words to the list
            {
                words.Add(value);
            }
        }

        if (words.Count == 0) // If the list is 0 long, that means there's 0 unhidden words. Returns true, as all are hidden
        {
            output = true;
        }
        return output; // If the above check doesn't go through, returns false as defined at the top of this function
    }
}