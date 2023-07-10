public class Game
{
    Inventory _inventory = new Inventory();
    Map _map = new Map("", "");
    List<InteractCommand> _interactions;

    public Game()
    {
        _inventory = new Inventory();
        _map = new Map("Map.txt", "Workshop");
        _interactions = new List<InteractCommand>();
    }
}