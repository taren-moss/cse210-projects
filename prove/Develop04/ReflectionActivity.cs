public class ReflectionActivity : Activity
{
    private List<string> _promptList = new List<string>();
    private List<string> _promptQuestions = new List<string>();


    public ReflectionActivity()
    {
        SetStartMessage("Welcome to the Reflection Activity.");
        SetDescription("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
        SetEndMessage($"You have completed the Reflection Activity.");
        SetLists();
    }

    private void SetLists()
    {
        string[] prompts = System.IO.File.ReadAllLines("ReflectionPrompts.txt");
        foreach (string item in prompts)
        {
            _promptList.Add(item);
        }

        string[] questions = System.IO.File.ReadAllLines("ReflectionQuestions.txt");
        foreach (string item in questions)
        {
            _promptQuestions.Add(item);
        }
    }

    private string NewPrompt()
    {
        Random random = new Random();
        int index = random.Next((_promptList.Count) - 1);
        
        return _promptList[index];
    }

    private string NewQuestion()
    {
        Random random = new Random();
        int index = random.Next((_promptQuestions.Count) - 1);
        
        return _promptQuestions[index];
    }

    public void RunReflection()
    {
        Start();
        int duration = GetDuration();

        Console.Clear();
        Console.WriteLine("Get Ready... ");
        Pause(2, "load");
        Console.WriteLine();
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();
        Console.WriteLine($" --- {NewPrompt()} --- ");
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press ENTER to continue.");
        Console.ReadLine();
        Console.WriteLine("Now ponder each of the following questions as they related to this experience.");
        Console.Write("You may begin in: ");
        Pause(5, "count");
        Console.Clear();

        DateTime targetTime = (DateTime.Now.AddSeconds(duration));
        while (DateTime.Now < targetTime)
        {
            Console.Write($"> {NewQuestion()} ");
            Pause(10, "load");
            Console.WriteLine();
        }

        Console.WriteLine();
        Console.Write("Well Done! ");
        Console.WriteLine();
        Pause(3, "load");
        Console.WriteLine();
        Console.WriteLine(GetEndMessage());
        Pause(5, "load");
    }
}