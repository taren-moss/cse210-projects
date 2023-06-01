using System;

class Program
{
    static void Main(string[] args)
    {
        MathAssignment mathTest = new MathAssignment();
        WritingAssignment writingTest = new WritingAssignment();

        Console.WriteLine(mathTest.GetSummary());
        Console.WriteLine(mathTest.GetHomeworkList());
        Console.WriteLine();
        Console.WriteLine(writingTest.GetSummary());
        Console.WriteLine(writingTest.GetWritingInformation());
    }
}