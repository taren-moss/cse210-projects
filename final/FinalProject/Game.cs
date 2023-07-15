public class Game
{
    ObjManager _objects = new ObjManager();
    Map _map = new Map();

    public Game(string index="Index.txt", string mapFile="Map.txt", string navFile="NavCommands.txt", string objFile="Objects.txt")
    {
        _objects = new ObjManager(objFile);
        _map = new Map(mapFile, navFile, "WORKSHOP");
    }

    public void RunCommand(string command, string filename="Index.txt")
    {
        int count = 0;
        int failCount = 0;
        Console.Clear();
        string[] data = System.IO.File.ReadAllLines($"GameData\\{filename}");
        foreach (string line in data)
        {
            if (count != 0)
            {
                string[] lineData = line.Split("|");
                if (lineData[0] == command.ToUpper())
                {
                    if (lineData[1] == "NAV")
                    {
                        _map.ParseCommand(command);
                    }
                    else if (lineData[1] == "OBJ")
                    {
                        _objects.TestParseCommand(command, _map.GetRoom());
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
            }
            else
            {
                failCount += 1;
            }
            count += 1;
        }
        if (failCount == data.Count())
            {
                Console.WriteLine("Invalid Command!");
            }
    }


    public Map GetMap()
    {
        return _map;
    }
    public ObjManager GetObj()
    {
        return _objects;
    }


    public void ExamineRoom()
    {
        _map.ExamineRoom();
    }


}