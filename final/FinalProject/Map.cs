public class Map
{
    private List<Room> _map = new List<Room>();
    private Room _currentRoom = new Room();
    private Room _previousRoom = new Room();


    public Map(string filename, string room)
    {
        GenerateRooms(filename);
        MoveToRoom("Workshop");
    }


    public Room GetRoom()
    {
        return _currentRoom;
    }


    private void GenerateRooms(string filename)
    {
        _map = new List<Room>();
        int lineCount = 0;

        string[] mapData = System.IO.File.ReadAllLines($"GameData\\{filename}");
        foreach (string line in mapData)
        {
            if (lineCount != 0)
            {
                string[] lineData = line.Split("|");
                _map.Add(new Room(lineData[0], bool.Parse(lineData[1]), lineData[2], lineData[3]));
            }
            lineCount += 1;
        }
    }

    public void MoveToRoom(string roomName)
    {
        foreach (Room room in _map)
        {
            if (room.GetRoomName() == roomName)
            {
                _currentRoom = room;
            }
        }
    }
}