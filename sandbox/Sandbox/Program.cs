using System;

class Program
{
    static void Main(string[] args)
    {
        DateTime currentDateTime = DateTime.Now;
        string currentDate = currentDateTime.ToShortDateString();
        string currentTime = currentDateTime.ToShortTimeString();

        string input_filename = "test_input_file.txt";
        string[] lines = System.IO.File.ReadAllLines(input_filename);

        foreach (string line in lines)
        {
            Console.WriteLine($" {line}");
            string[] sections = line.Split(",");

            string pt1 = sections[0];
            string pt2 = sections[1];
            string pt3 = sections[2];
            string pt4 = sections[3];
            Console.WriteLine($" {pt1},{pt3},{pt2},{pt4}");
            Console.WriteLine($"{pt4}, {pt1},{pt3},{pt2}");
            Console.WriteLine("");
        }

        string output_filename = "test_output_file.txt";

        using (StreamWriter outputFile = new StreamWriter(output_filename))
        {
            outputFile.WriteLine("Boo! This is a  s p o o k y  file.");

            string variable = "(o.o)";
            outputFile.WriteLine($"Look at this dude >> {variable}");
            outputFile.WriteLine($"The date is {currentDate}");
        }

        string final_output = "test_user_output.txt";
        string[] importData = System.IO.File.ReadAllLines(final_output);

        using (StreamWriter outputFile = new StreamWriter(final_output))
        {
            foreach (string line in importData)
            {
                outputFile.WriteLine(line);
            }
            Console.Write("Type something to add to the file: ");
            string userInput = Console.ReadLine();

            outputFile.Write($"Witten on {currentDate} at {currentTime}: ");
            outputFile.WriteLine(userInput);
        }
    }
}