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

            testGame.RunCommand(input);
        }
    }
}