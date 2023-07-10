public class RoomCommand : Command
{
    protected string _roomRequirement;
    protected bool _needsExamined;


    public RoomCommand() : base()
    {
        _roomRequirement = "";
        _needsExamined = false;
    }
    public RoomCommand(string name, bool hasRequirements, string room, bool needsExamined, string output) : base(name, "room", hasRequirements, output)
    {
        _roomRequirement = room;
        _needsExamined = needsExamined;
    }


    public string GetRoomRequirement()
    {
        return _roomRequirement;
    }
    public bool GetExamineRequirement()
    {
        return _needsExamined;
    }

    public void SetRoomRequirement(string room)
    {
        _roomRequirement = room;
    }
    public void SetExamineRequirement(bool boolean)
    {
        _needsExamined = boolean;
    }


    protected override bool CheckRequirements()
    {
        return base.CheckRequirements();
    }
    protected override void RunCommand()
    {
        base.RunCommand();
    }
}