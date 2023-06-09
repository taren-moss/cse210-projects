using System;

class Program
{
    static void Main(string[] args)
    {
        List<string> frames = new List<string>();
        frames.Add("\u25d0");
        frames.Add("\u25d3");
        frames.Add("\u25d1");
        frames.Add("\u25d2");

        Console.OutputEncoding = System.Text.Encoding.UTF8;
        for (int i = (2 * 2); i>0; i--)
        {
            foreach (string s in frames)
            {
                Console.Write(s);
                Thread.Sleep(125);
                Console.Write("\b \b");
            }
        }
    }
}