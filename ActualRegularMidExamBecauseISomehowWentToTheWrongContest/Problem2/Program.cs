
namespace Problem2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> coffeeInStock = Console.ReadLine()
                .Split(" ")
                .ToList();

            int commandCount = int.Parse(Console.ReadLine());
            string command = "";
            List<string> arguments = new List<string>();

            for (int i = 0; i < commandCount; i++)
            {
                command = Console.ReadLine();
                arguments = command
                    .Split(" ")
                    .ToList();
                command = arguments[0];
                arguments.RemoveAt(0);

                switch (command)
                {
                    case "Include":
                        coffeeInStock.Add(arguments[0]);
                        break;
                    case "Reverse":
                        coffeeInStock.Reverse();
                        break;
                    case "Prefer":
                        coffeePrefer(coffeeInStock, arguments[0], arguments[1]);
                        break;
                    case "Remove":
                        coffeeRemove(coffeeInStock, arguments[0], arguments[1]);
                        break;
                }
            }

            Console.WriteLine($"Coffees:\n{string.Join(' ', coffeeInStock)}");
        }

        private static void coffeeRemove(List<string> coffeeInStock, string at, string numberOfCoffees)
        {
            int numberOfCoffeesInt = int.Parse(numberOfCoffees);

            switch (at)
            {
                case "first":
                    coffeeInStock.RemoveRange(0, numberOfCoffeesInt);
                    break;
                case "last":

                    // fuck you
                    for (int i = 0; i < numberOfCoffeesInt; i++)
                    {
                        coffeeInStock.RemoveAt(coffeeInStock.Count-1);
                    }
                    break;
            }
        }

        private static void coffeePrefer(List<string> coffeeInStock, string coffeeIndexOne, string coffeeIndexTwo)
        { 
            int coffeeIndexOneInt = int.Parse(coffeeIndexOne);
            int coffeeIndexTwoInt = int.Parse(coffeeIndexTwo);
            string hold = "";

            // c = a
            // a = b
            // b = c

            if (checkIfInBounds(coffeeInStock, coffeeIndexOneInt) == checkIfInBounds(coffeeInStock, coffeeIndexTwoInt))
                
            {
                coffeeIndexOne = coffeeInStock[coffeeIndexOneInt];
                coffeeIndexTwo = coffeeInStock[coffeeIndexTwoInt];

                // swap

                hold = coffeeIndexOne;
                coffeeInStock[coffeeIndexOneInt] = coffeeIndexTwo;
                coffeeInStock[coffeeIndexTwoInt] = hold;
            }


        }

        private static bool checkIfInBounds(List<string> list, int index)
        {
            return (0 > index)
                && (index <=  list.Count - 1);
        }
    }
}