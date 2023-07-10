public class Inventory
{
    private List<Item> _inventory = new List<Item>();


    public Item GetItem(int index)
    {
        if (index >= _inventory.Count())
        {
            return _inventory[index];
        }
        else
        {
            return new Item();
        }
    }

    public void AddItem(Item item)
    {
        _inventory.Add(item);
    }
}