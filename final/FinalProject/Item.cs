public class Item : Object
{
    public Item() : base()
    {
    }
    public Item(string name, string description, Room location) : base(name, description, location)
    {
    }


    public override void Interact()
    {
        base.Interact();
    }
}