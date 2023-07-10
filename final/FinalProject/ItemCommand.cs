public class ItemCommand : Command
{
    Item _item;
    Room _roomRequirement;

    public ItemCommand() : base()
    {
        _item = new Item();
        _roomRequirement = new Room();
    }
    public ItemCommand(Item item, string name, Room roomRequirement, bool meetRequirement, string output) : base(name, "item", meetRequirement, output)
    {
        _item = item;
        _roomRequirement = roomRequirement;
    }


    public Item GetItem()
    {
        return _item;
    }
    public Room GetRoomRequirement()
    {
        return _roomRequirement;
    }

    public void SetItem(Item item)
    {
        _item = item;
    }
    public void SetRoomRequirement(Room room)
    {
        _roomRequirement = room;
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