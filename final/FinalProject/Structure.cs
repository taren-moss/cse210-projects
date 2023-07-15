public class Structure : Object
{
    bool _hasReward;
    string _rewardItem;

    public Structure() : base()
    {
        _hasReward = false;
        _rewardItem = "";
    }
    public Structure(string name, string location, bool needsExamined, string description, bool hasReward, string reward) : base(name, "STRUCTURE", location, needsExamined, description)
    {
        _hasReward = hasReward;
        _rewardItem = reward;
    }


    public override string Interact(Room currentRoom)
    {
        if (_location == currentRoom.GetRoomName())
        {
            if (_hasReward)
            {
                return $"true|{_rewardItem}|{_objectName}|{_objectDescription}";
            }
            else
            {
                return $"false|{_objectName}|{_objectDescription}";
            }
        }
        else
        {
            return $"Invalid Command!";
        }
    }
}