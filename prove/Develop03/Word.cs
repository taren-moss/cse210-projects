public class Word
{
    private string _word = "test"; // This variable is the text of the word
    private bool _hidden = false; // This variable is the hidden status of the word
    // Each Word Object has a _hidden variable that indicates if it is hidden (true) or visible (false). By default they are
    // visible (false). When a word is hidden using the Hide() function, each character in _word is replaced with '_'
    // For example "Rock" would become "____" (that's 4 underscores). And then _hidden is changed to true

    public Word() // Default Constructor
    {
        _word = "";
        _hidden = false;
    }

    public Word(string input) // Alternate Constructor
    {
        _word = input;
        _hidden = false;
    }

    public bool CheckStatus() // Checks _hidden for true or false and returns what it finds
    {
        bool output = false;
        if (_hidden == true)
        {
            output = true;
        }
        else
        {
            output = false;
        }
        return output;
    }

    public void Hide() // Hides a word by replacing the string in _word with a new string equally long made with underscores
    {
        // Got some ideas/help from https://stackoverflow.com/a/28103415 and https://learn.microsoft.com/en-us/dotnet/api/system.char?view=net-7.0
        char[] wordArray = _word.ToCharArray(); // I don't really know how this works. I just know it does. Refer to above links.
        int i = 0;

        foreach (char c in wordArray)
        {
            wordArray[i] = '_'; // Single quotes (') are characters, apparently. This worked, but "_" did not, because it was a string.
            i += 1;
        }

        _word = new string(wordArray); // It seems 'new string()' can accept a Char(acter) array and build a word out of it. That's this.
        _hidden = true; // Once the word has been replaced with underscores it's marked as hidden
    }

    public string GetWord() // Simply gets the _word value and returns it
    {
        return _word;
    }
}