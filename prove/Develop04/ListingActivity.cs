public class ListingActivity : Activity
{
    private int _count = 0;
    private List<string> _promptList = new List<string>();

     public ListingActivity()
    {
        SetStartMessage("Welcome to the Listing Activity.");
        SetDescription("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
        SetEndMessage($"You have completed the Listing Activity.");
        SetLists();
    }

    private void SetLists()
    {
        string[] prompts = System.IO.File.ReadAllLines("ListingPrompts.txt");
        foreach (string item in prompts)
        {
            _promptList.Add(item);
        }
    }

    private string NewPrompt()
    {
        Random random = new Random();
        int index = random.Next((_promptList.Count) - 1);
        
        return _promptList[index];
    }

    public void RunListing()
    {
        Start();
        int duration = GetDuration();
        Console.Write(_count);

        Console.Clear();
        Console.WriteLine("Get Ready... ");
        Pause(2, "load");
        Console.WriteLine();
        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine();
        Console.WriteLine($" --- {NewPrompt()} --- ");
        Console.WriteLine();
        Console.Write("You may begin in: ");
        Pause(5, "count");
        Console.WriteLine();

        DateTime targetTime = (DateTime.Now.AddSeconds(duration));
        int countingNumber = 0;
        while (DateTime.Now < targetTime)
        {
            Console.Write("< ");
            Console.ReadLine();
            countingNumber += 1;
        }
        _count = countingNumber;
        Console.WriteLine($"You listed {_count} items!");
         Console.WriteLine();
        Console.Write("Well Done! ");
        Console.WriteLine();
        Pause(3, "load");
        Console.WriteLine();
        Console.WriteLine(GetEndMessage());
        Pause(5, "load");


    }
}