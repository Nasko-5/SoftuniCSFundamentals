namespace _5.Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string item = Console.ReadLine();
            int itemQuantity = int.Parse(Console.ReadLine());

            double price = getItemPrice(item, itemQuantity);

            Console.WriteLine($"{price:F2}");
        }

        private static double getItemPrice(string? item, int itemQuantity)
        {
            switch (item)
            {
                case "coffee":
                    return 1.50 * itemQuantity;
                    break;
                case "water":
                    return 1.00 * itemQuantity;
                    break;
                case "coke":
                    return 1.40 * itemQuantity;
                    break;
                case "snacks":
                    return 2.00 * itemQuantity;
                    break;
                default:
                    return itemQuantity;
            }
        }
    }
}