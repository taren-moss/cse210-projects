public abstract class ObjectThing
{
    protected string _objectName;
    protected string _objectType;
    protected string _location;
    protected bool _needsExamined;
    protected string _objectDescription;


    public ObjectThing()
    {
        _objectName = "";
        _objectType = "";
        _location = "";
        _needsExamined = false;
        _objectDescription = "";
    }
    public ObjectThing(string name, string type, string room, bool needsExamined, string description)
    {
        _objectName = name;
        _objectType = type;
        _location = room;
        _needsExamined = needsExamined;
        _objectDescription = description;
    }


    public string GetName()
    {
        return _objectName;
    }
    public string GetObjectType()
    {
        return _objectType;
    }
    public string GetLocation()
    {
        return _location;
    }
    public bool GetNeedsExamined()
    {
        return _needsExamined;
    }
    public string GetDescription()
    {
        return _objectDescription;
    }
    public virtual string[] GetOtherData()
    {
        return null;
    }


    public void SetName(string name)
    {
        _objectName = name;
    }
    public void SetType(string type)
    {
        _objectType = type;
    }
    public void SetDescription(string description)
    {
        _objectDescription = description;
    }
    public void SetRoom(string room)
    {
        _location = room;
    }

    public virtual string Interact(Room currentRoom)
    {
        return null;
    }
}