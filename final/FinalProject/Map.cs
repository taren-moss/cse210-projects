public class Map
{
    private List<Room> _map = new List<Room>();
    private List<NavCommand> _navCommands = new List<NavCommand>();
    private Room _currentRoom = new Room();


    public Map(string roomFile="Map.txt", string navFile="NavCommands.txt", string room = "WORKSHOP")
    {
        GenerateRooms(roomFile);
        GenerateCommands(navFile);
        MoveToRoom("WORKSHOP");
    }


    public Room GetRoom()
    {
        return _currentRoom;
    }


    public void GenerateRooms(string filename="Map.txt")
    {
        _map = new List<Room>();
        int count = 0;

        string[] mapData = System.IO.File.ReadAllLines($"GameData\\{filename}");
        foreach (string line in mapData)
        {
            if (count != 0)
            {
                string[] lineData = line.Split("|");
                _map.Add(new Room(lineData[0], bool.Parse(lineData[1]), lineData[2], lineData[3]));
            }
            count += 1;
        }
    }
    public void GenerateCommands(string filename="NavCommands.txt")
    {
        Room ParseRoom(string name)
        {
            Room output = new Room();
            foreach (Room room in _map)
            {
                if (room.GetRoomName() == name)
                {
                    output = room;
                }
            }
            return output;
        }

        _navCommands = new List<NavCommand>();
        int count = 0;

        string[] navData = System.IO.File.ReadAllLines($"GameData\\{filename}");
        foreach (string line in navData)
        {
            if (count != 0)
            {
                string[] lineData = line.Split("|");
                _navCommands.Add(new NavCommand(lineData[0], ParseRoom(lineData[1]), ParseRoom(lineData[2]), bool.Parse(lineData[3]), lineData[4]));
            }
            count += 1;
        }
    }


    private void MoveToRoom(string name)
    {
        foreach (Room room in _map)
        {
            if (room.GetRoomName() == name.ToUpper())
            {
                _currentRoom = room;
            }
        }
    }


    public void ExamineRoom()
    {
        _currentRoom.ExamineRoom();
    }

    public void ParseCommand(string command)
    {
        int failCount = 0;
        if (command.ToUpper() == "EXAMINE")
        {
            _currentRoom.ExamineRoom();
        }
        else
        {
            foreach (NavCommand navCommand in _navCommands)
            {
                if (navCommand.GetName() == command.ToUpper())
                {
                    if (navCommand.GetRoomRequirement() == _currentRoom)
                    {
                        if (navCommand.GetExamineRequirement() == true)
                        {
                            if (_currentRoom.CheckExamined() == true)
                            {
                                MoveToRoom(navCommand.EnterRoom().GetRoomName());
                                Console.WriteLine(navCommand.GetOutput());
                            }
                            else
                            {
                                failCount += 1;
                            }
                        }
                        else
                        {
                            MoveToRoom(navCommand.EnterRoom().GetRoomName());
                            Console.WriteLine(navCommand.GetOutput());
                        }
                    }
                    else
                    {
                        failCount += 1;
                    }
                }
                else
                {
                    failCount += 1;
                }
                
                if (failCount == _navCommands.Count())
                {
                    Console.WriteLine("Invalid Command!");
                }
            }
        }
    }
}