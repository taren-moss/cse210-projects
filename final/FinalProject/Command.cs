public class Command
{
    protected string _commandName;
    protected string _commandType;
    protected string _outputText;
    protected bool _meetsRequirements;


    protected Command()
    {
        _commandName = "";
        _commandType = "";
        _outputText = "";
        _meetsRequirements = false;
    }
    protected Command(string name, string type, bool requirements, string output)
    {
        _commandName = name;
        _commandType = type;
        _outputText = output;
        _meetsRequirements = requirements;
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
    public void SetPass(bool pass)
    {
        _meetsRequirements = pass;
    }


    protected virtual bool CheckRequirements()
    {
        return _meetsRequirements;
    }
    protected virtual void RunCommand()
    {
        Console.WriteLine();
    }
}