public class Command
{
    protected string _commandName;
    protected string _commandType;
    protected string _outputText;


    protected Command()
    {
        _commandName = "";
        _commandType = "";
        _outputText = "";
    }
    protected Command(string name, string type, string output)
    {
        _commandName = name;
        _commandType = type;
        _outputText = output;
    }


    public string GetName()
    {
        return _commandName;
    }
    public string GetCommandType()
    {
        return _commandType;
    }
    public string GetOutput()
    {
        return _outputText;
    }


    public void SetName(string name)
    {
        _commandName = name;
    }
    public void SetType(string type)
    {
        _commandType = type;
    }
    public void SetOutput(string output)
    {
        _outputText = output;
    }


    protected virtual void RunCommand()
    {
        Console.WriteLine();
    }
}