public class ObjManager
{
    private List<Object> _gameObjects = new List<Object>();

    public ObjManager(string objFile="Objects.txt")
    {
        GenerateObjects(objFile);
    }


    public void GenerateObjects(string filename)
    {
        _gameObjects = new List<Object>();
        int count = 0;

        string[] objData = System.IO.File.ReadAllLines($"GameData\\{filename}");
        foreach (string line in objData)
        {
            if (count != 0)
            {
                string[] lineData = line.Split("|");
                if (lineData[1] == "STRUCTURE")
                {
                    _gameObjects.Add(new Structure(lineData[0], lineData[2], bool.Parse(lineData[3]), lineData[4], bool.Parse(lineData[5]), lineData[6]));
                }
                else if (lineData[1] == "ITEM")
                {
                    _gameObjects.Add(new Item(lineData[0], lineData[2], bool.Parse(lineData[3]), lineData[4], bool.Parse(lineData[5]), lineData[6]));
                }
            }
            count += 1;
        }
    }


    public void DescribeVisibleItem(Room currentRoom)
    {
        List<Item> itemList = _gameObjects.OfType<Item>().ToList();
        foreach (Item item in itemList)
        {
            if (currentRoom.GetRoomName() == item.GetLocation() && item.GetOtherData()[0] == "false")
            {
                if (item.GetNeedsExamined() == true)
                {
                    if (currentRoom.CheckExamined() == true)
                    {
                        Console.WriteLine(item.GetOtherData()[1]);
                    }
                }
                else
                {
                    Console.WriteLine(item.GetOtherData()[1]);
                }
            }
        }
    }


    public string AddItem(Item item, Room currentRoom)
    {
        return item.Interact(currentRoom);
    }

    public string CheckStructure(string input, Room currentRoom)
    {
        string[] output = input.Split("|");
        if (output[0] == "true")
        {
            List<Item> itemList = _gameObjects.OfType<Item>().ToList();
            int failCount = 0;
            string returnValue = "";
            foreach (Item item in itemList)
            {
                if (item.GetName() == output[1])
                {
                    returnValue = $"{output[2]} - {output[3]} {AddItem(item, currentRoom)}";
                }
                else
                {
                    failCount += 1;
                }
            }
            if (failCount != itemList.Count())
            {
                return returnValue;
            }
            else
            {
                return "Invalid Command!";
            }
        }
        else
        {
            return $"{output[1]} - {output[2]}";
        }
    }


    public void ListInventory()
    {
        Console.WriteLine("Your inventory:");
        List<Item> items = _gameObjects.OfType<Item>().ToList();
        int itemCount = 0;
        foreach (Item item in items)
        {
            string[] data = item.GetOtherData();
            if (data[0] == "true")
            {
                Console.WriteLine($"- {item.GetName()}: {item.GetDescription()}");
                itemCount += 1;
            }
        }
        if (itemCount == 0)
        {
            Console.WriteLine("You aren't holding any items.");
        }
        Console.WriteLine();
    }


    public void TestParseCommand(string command, Room currentRoom)
    {
        int failCount = 0;
        if (command.ToUpper() == "INVENTORY" || command.ToUpper() == "INV")
        {
            ListInventory();
        }
        else
        {
            foreach (Object obj in _gameObjects)
            {
                if (obj.GetName() == command.ToUpper() && obj.GetLocation() == currentRoom.GetRoomName())
                {
                    if (obj.GetNeedsExamined() == true)
                    {
                        if (currentRoom.CheckExamined() == true)
                        {
                            if (obj.GetObjectType() == "STRUCTURE")
                            {
                                string output = obj.Interact(currentRoom);
                                Console.WriteLine(CheckStructure(output, currentRoom));
                            }
                            else if (obj.GetObjectType() == "ITEM")
                            {
                                List<Item> itemList = _gameObjects.OfType<Item>().ToList();
                                foreach (Item item in itemList)
                                {
                                    if (item.GetName() == command.ToUpper())
                                    {
                                        Console.WriteLine(AddItem(item, currentRoom));
                                    }
                                }
                            }
                            else
                            {
                                failCount += 1;
                            }
                        }
                        else
                        {
                            failCount += 1;
                        }
                    }
                    else
                    {
                        if (obj.GetObjectType() == "STRUCTURE")
                        {
                            string output = obj.Interact(currentRoom);
                            Console.WriteLine(CheckStructure(output, currentRoom));
                        }
                        else if (obj.GetObjectType() == "ITEM")
                        {
                            List<Item> itemList = _gameObjects.OfType<Item>().ToList();
                            foreach (Item item in itemList)
                            {
                                if (item.GetName() == command.ToUpper())
                                {
                                    Console.WriteLine(AddItem(item, currentRoom));
                                }
                            }
                        }
                        else
                        {
                            failCount += 1;
                        }
                    }
                }
                else
                {
                    failCount += 1;
                }
            }
            if (failCount == _gameObjects.Count())
            {
                Console.WriteLine("Invalid Command!");
            }
        }
    }
}