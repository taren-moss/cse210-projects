public class Item : Object
{
    bool _inInventory;
    private string _visibleDescription;

    public Item() : base()
    {
        _visibleDescription = "";
        _inInventory = false;
    }
    public Item(string name, string location, bool needsExamined, string description, bool inInventory, string altDescription) : base(name, "ITEM", location, needsExamined, description)
    {
        _visibleDescription = altDescription;
        _inInventory = inInventory;
    }


    public override string[] GetOtherData()
    {
        string[] output = new string[2];
        if (_inInventory)
        {
            output[0] = "true";
        }
        else
        {
            output[0] = "false";
        }
        output[1] = _visibleDescription;

        return output;
    }


    public override string Interact(Room currentRoom)
    {
        if (_inInventory)
        {
            return $"There's no more {_objectName} to pick up.";
        }
        else if (_location == currentRoom.GetRoomName())
        {
            _inInventory = true;
            return $"You picked up {_objectName}";
        }
        else
        {
            return "Invalid Command!";
        }
        
    }
}