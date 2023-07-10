public abstract class Object
{
    protected string _objectName;
    protected string _objectDescription;
    protected Room _location;


    public Object()
    {
        _objectName = "";
        _objectDescription = "";
        _location = new Room();
    }
    public Object(string name, string description, Room room)
    {
        _objectName = name;
        _objectDescription = description;
        _location = room;
    }


    public string GetName()
    {
        return _objectName;
    }
    public string GetDescription()
    {
        return _objectDescription;
    }
    public Room GetLocation()
    {
        return _location;
    }


    public void SetName(string name)
    {
        _objectName = name;
    }
    public void SetDescription(string description)
    {
        _objectDescription = description;
    }
    public void SetRoom(Room room)
    {
        _location = room;
    }


    public void PrintDescription()
    {
        
    }
    public virtual void Interact()
    {

    }
}