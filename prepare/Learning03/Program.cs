using System;

class Program
{
    static void Main(string[] args)
    {
        static void EasyRerun(int value1, int value2)
        {
            Fraction test = new Fraction(value1, value2);
            string testString = test.GetFractionString();
            double testDouble = test.GetDecimalValue();

            Console.WriteLine($"Fraction: {testString}");
            Console.WriteLine($"Decimal: {testDouble}");
            Console.WriteLine();
        }

        EasyRerun(1, 1);
        EasyRerun(5, 1);
        EasyRerun(3, 4);
        EasyRerun(1, 3);
    }
}