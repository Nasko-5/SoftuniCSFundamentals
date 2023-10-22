namespace Problem3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> inventory = Console.ReadLine()
                .Split(", ")
                .ToList();

            string command = "";
            string argument = "";
            string[] arguments = new string[2];

            while ((command =  Console.ReadLine()) != "Craft!") 
            {
                arguments = command.Split(" - ");
                command = arguments[0];
                argument = arguments[1];

                switch (command)
                {
                    case "Collect":
                        inventoryCollect(inventory, argument);
                        break;
                    case "Drop":
                        inventoryDrop(inventory, argument);
                        break;
                    case "Combine Items":
                        inventoryCombine(inventory, argument);
                        break;
                    case "Renew":
                        inventoryRenew(inventory, argument);
                        break;
                }
            }

            Console.WriteLine(string.Join(", " , inventory));
        }

        // •	"Renew – {item}" – if the given item exists, you should change its position and put it last in your inventory.
        private static void inventoryRenew(List<string> inventory, string item)
        {
            if (inventory.Contains(item))
            {
                inventory.Remove(item);
                inventory.Add(item);
            }
        }

        // •	"Combine Items - {old_item}:{new_item}" - you should check if the old item exists. If so, add the new item after the old one. Otherwise, ignore the command.
        private static void inventoryCombine(List<string> inventory, string argument)
        {
            string[] splitArgument = argument.Split(":");
            string oldItem = splitArgument[0];
            string newItem = splitArgument[1];

            if (inventory.Contains(oldItem))
            {
                inventory.Insert(inventory.IndexOf(oldItem)+1, newItem);
            }
        }

        // •	"Drop - {item}" - you should remove the item from your inventory if it exists.
        private static void inventoryDrop(List<string> inventory, string item)
        {
            if (inventory.Contains(item))
            {
                inventory.Remove(item);
            }
        }

        // •	"Collect - {item}" - you should add the given item to your inventory. If the item already exists, you should skip this line.
        private static void inventoryCollect(List<string> inventory, string item)
        {
            if (!inventory.Contains(item))
            {
                inventory.Add(item);
            }
        }

    }
}