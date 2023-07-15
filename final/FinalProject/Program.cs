using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        bool loop = true;
        Game testGame = new Game("Index.txt", "Map.txt", "NavCommands.txt", "Objects.txt");
        while (loop)
        {
            Room testRoom = testGame.GetMap().GetRoom();
            Console.WriteLine(testRoom.GetRoomDescription());
            testGame.GetObj().DescribeVisibleItem(testRoom);
            Console.WriteLine();
            Console.Write("What do you do? ");
            string input = Console.ReadLine();

            if (input.ToUpper() == "QUIT" || input.ToUpper() == "CLOSE")
            {
                Console.WriteLine("[Ending Program...]");
                Thread.Sleep(500);
                loop = false;
            }
            else
            {
                testGame.RunCommand(input);
            }
        }
        Console.WriteLine("[Program Ended]");
    }
}