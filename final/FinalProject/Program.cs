using System;

class Program
{
    static void Main(string[] args)
    {
        Map testMap = new Map("Map.txt", "Workshop");
        Room testRoom = testMap.GetRoom();
        Console.WriteLine(testRoom.GetRoomName());
        Console.WriteLine(testRoom.GetRoomDescription());
        Console.WriteLine();
        testRoom.ExamineRoom();
        Console.WriteLine($"Examined {testRoom.GetRoomName()}");
        Console.WriteLine(testRoom.GetRoomDescription());
        Console.WriteLine();

        testMap.MoveToRoom("Yard");
        testRoom = testMap.GetRoom();
        Console.WriteLine(testRoom.GetRoomName());
        Console.WriteLine(testRoom.GetRoomDescription());
        Console.WriteLine();
        testRoom.ExamineRoom();
        Console.WriteLine($"Examined {testRoom.GetRoomName()}");
        Console.WriteLine(testRoom.GetRoomDescription());
        Console.WriteLine();
    }
}