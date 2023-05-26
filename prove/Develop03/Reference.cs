public class Reference
{
    private string _book = "";
    private string _chapter = "";
    private string _startVerse = "";
    private string _endVerse = "";
    private string _scriptureVerses = "";

    public Reference() // Default Constructor
    {
        _book = "Jacob";
        _chapter = "6";
        _startVerse = "11";
        _endVerse = "13";
        _scriptureVerses = "O then, my beloved brethren, repent ye, and enter in at the strait gate, and continue in the way which is narrow, until ye shall obtain eternal life. O be awise; what can I say more? Finally, I bid you farewell, until I shall meet you before the pleasing bar of God, which bar striketh the wicked with awful dread and fear. Amen.";
    }
    public Reference(string alt) // Alternate Constructor
    {
        if (alt == "alt") // This is an awkward way to handle it. Just here for testing purposes.
        {
            _book = "Jacob";
            _chapter = "6";
            _startVerse = "12";
            _endVerse = "";
            _scriptureVerses = "O be awise; what can I say more?";
        }
        
        else
        {
            _book = "Jacob";
            _chapter = "6";
            _startVerse = "11";
            _endVerse = "13";
            _scriptureVerses = "O then, my beloved brethren, repent ye, and enter in at the strait gate, and continue in the way which is narrow, until ye shall obtain eternal life. O be awise; what can I say more? Finally, I bid you farewell, until I shall meet you before the pleasing bar of God, which bar striketh the wicked with awful dread and fear. Amen.";
        }
    }

    public string AssembleVerseInfo() // Assembles information and returns it as a single string
    {
        string assembledVerses = "";

        if (_endVerse == "") // Checks if there's even relevant information in _endVerse
        {
            assembledVerses = $"{_book} {_chapter}: {_startVerse}"; // If not, ignore it
        }
        else
        {
            assembledVerses = $"{_book} {_chapter}: {_startVerse}-{_endVerse}"; // Ig so, include it
        }

        return assembledVerses; // Returns as a single string
    }

    public List<Word> MakeWordList() // Splits _scriptureVerses into words and then makes a Word Object for each word
    {
        List<Word> wordList = new List<Word>(); // List to hold the Word Object data
        foreach (string word in _scriptureVerses.Split(" "))
        {
            Word value = new Word(word); // Creates Word Objects via constructors in the Word Object code
            wordList.Add(value); // Adds the Word Object to the list
        }

        return wordList; // Returns the list
    }
}