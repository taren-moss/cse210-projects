public class Activity
{
    private string _startMessage = "";
    private string _endMessage = "";
    private int _duration = 0;
    private string _description = "";

    protected void SetDuration(int duration)
    {
        _duration = duration;
    }

    protected void SetStartMessage(string message)
    {
        _startMessage = message;
    }

    protected void SetEndMessage(string message)
    {
        _endMessage = message;
    }

    protected void SetDescription(string message)
    {
        _description = message;
    }



    protected int GetDuration()
    {
        return _duration;
    }

    protected string GetStartMessage()
    {
        return _startMessage;
    }

    protected string GetEndMessage()
    {
        return _endMessage;
    }

    protected string GetDescription()
    {
        return _description;
    }



    protected void Pause(int duration, string type)
    {
        if (type == "load")
        {
            List<string> frames = new List<string>();
            frames.Add("\u25d0");
            frames.Add("\u25d3");
            frames.Add("\u25d1");
            frames.Add("\u25d2");

            Console.OutputEncoding = System.Text.Encoding.UTF8;
            for (int i = (duration * 2); i > 0; i--)
            {
                foreach (string s in frames)
                {
                    Console.Write($"{s} ");
                    Thread.Sleep(125);
                    Console.Write("\b\b \b");
                }
            }
        }
        else
        {
            for (int i = duration; i > 0; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
        }
    }

    protected void Start()
    {
        Console.WriteLine(GetStartMessage());
        Console.WriteLine();
        Console.WriteLine(GetDescription());
        Console.WriteLine();
        Console.Write("How long in seconds would you like this session to be? ");
        int userInput = int.Parse(Console.ReadLine());
        SetDuration(userInput);
    }
}