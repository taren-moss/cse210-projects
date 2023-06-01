public class MathAssignment : Assignment
{
    private string _textbookSection = "";
    private string _problems = "";
    public MathAssignment()
    {
        SetName();
        SetTopic("Calculus");
        _textbookSection = "1.0";
        _problems = "1-5";
    }

    public string GetHomeworkList()
    {
        string output = $"Section {_textbookSection } Problems {_problems}";
        return output;
    }
}