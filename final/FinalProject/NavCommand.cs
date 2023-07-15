public class NavCommand : Command
{
    protected Room _roomRequirement;
    protected Room _targetRoom;
    protected bool _needsExamined;


    public NavCommand() : base()
    {
        _roomRequirement = new Room();
        _targetRoom = new Room();
        _needsExamined = false;
    }
    public NavCommand(string name, Room room, Room target, bool needsExamined, string output) : base(name, "Nav", output)
    {
        _roomRequirement = room;
        _targetRoom = target;
        _needsExamined = needsExamined;
    }


    public Room GetRoomRequirement()
    {
        return _roomRequirement;
    }
    public Room EnterRoom()
    {
        return _targetRoom;
    }
    public bool GetExamineRequirement()
    {
        return _needsExamined;
    }

    public void SetRoomRequirement(Room room)
    {
        _roomRequirement = room;
    }
    public void SetExamineRequirement(bool boolean)
    {
        _needsExamined = boolean;
    }


    protected override void RunCommand()
    {
        base.RunCommand();
    }
}