public class Assignment
{
    protected string _name = "name";
    private string _topic =  "topic";

    public string GetSummary()
    {
        string output = $"{_name} - {_topic}";
        return output;
    }

    public void SetName(string name = "John Doe")
    {
        _name = name;
    }

    public void SetTopic(string topic)
    {
        _topic = topic;
    }
}