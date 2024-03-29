public class Room
{
    private string _roomName;
    private bool _roomExamined;
    private string _roomDescription;
    private string _examinedDescription;


    public Room()
    {
        _roomName = "";
        _roomExamined = false;
        _roomDescription = "";
        _examinedDescription = "";
    }
    public Room(string name, bool examined, string description, string examinedDescription)
    {
        _roomName = name;
        _roomExamined = examined;
        _roomDescription = description;
        _examinedDescription = examinedDescription;
    }


    public string GetRoomName()
    {
        return _roomName;
    }
    public string GetRoomDescription()
    {
        if (_roomExamined)
        {
            return _examinedDescription;
        }
        else
        {
            return _roomDescription;
        }
    }
    public bool CheckExamined()
    {
        return _roomExamined;
    }

    public void ExamineRoom()
    {
        if (_roomExamined)
        {
            Console.WriteLine($"{_roomName} - You already examined the {_roomName.ToLower()}.");
        }
        else
        {
            _roomExamined = true;
            Console.WriteLine($"{_roomName} - You examine the {_roomName.ToLower()}.");
        }
    }
}