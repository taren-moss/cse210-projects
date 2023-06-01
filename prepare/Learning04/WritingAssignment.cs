public class WritingAssignment : Assignment
{
    private string _title = "";
    public WritingAssignment()
    {
        SetName();
        SetTopic("History");
        _title = "Title for an Assignment about History";
    }

    public string GetWritingInformation()
    {
        string output = $"{_title} by {_name}";
        return output;
    }
}