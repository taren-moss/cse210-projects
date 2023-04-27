using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a number to add, or type 0 when finished");

        bool loop = true;
        while (loop == true)
        {
            Console.Write("Enter a Number: ");
            string userInput = Console.ReadLine();
            int userNumber = int.Parse(userInput);

            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
            else
            {
                loop = false;
            }
        }
        int sum = 0;
        int numCount = 0;
        int largestNum = 0;
        foreach (int num in numbers)
        {
            sum += num;
            numCount += 1;
            if (num > largestNum)
            {
                largestNum = num;
            }
        }
        float average = (((float)sum)/numCount);

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largestNum}");
    }
}