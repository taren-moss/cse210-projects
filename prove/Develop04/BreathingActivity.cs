public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        SetStartMessage("Welcome to the Breathing Activity.");
        SetDescription("This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");
        SetEndMessage($"You have completed the Breathing Activity.");
    }

    private void Breathe(string message, int duration)
    {
        Console.Write(message);
        Pause(duration, "count");
        Console.WriteLine();
    }

    public void RunBreathing()
    {
        Start();
        int duration = GetDuration();

        Console.Clear();
        Console.WriteLine("Get Ready... ");
        Pause(3, "load");
        Console.WriteLine();

        DateTime targetTime = (DateTime.Now.AddSeconds(duration));
        while (DateTime.Now < targetTime)
        {
            Breathe("Breathe in... ", 5);
            Breathe("Hold... ", 1);
            Breathe("Breathe out... ", 5);
            Breathe("Hold... ", 1);
            Console.WriteLine();
        }
        Console.Write("Well Done! ");
        Pause(3, "load");
        Console.WriteLine();
        Console.WriteLine(GetEndMessage());
        Pause(5, "load");

    }
}