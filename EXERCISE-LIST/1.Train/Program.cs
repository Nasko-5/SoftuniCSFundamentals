namespace _1.Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int maxWagonCapacity = int.Parse(Console.ReadLine());

            string commmand;
            List<string> argumentsList = new List<string>();

            while ((commmand = Console.ReadLine()) != "end")
            {
                argumentsList = commmand.Split(' ').ToList();

                string argumentOne = argumentsList[0];
                int argumentOneInt = argumentOne.Any(char.IsDigit) ? int.Parse(argumentOne) : 0;

                int argumentTwo = argumentsList.Count == 2 ? int.Parse(argumentsList[1]) : 0;

                if (argumentOne == "Add")
                {
                    wagons.Add(argumentTwo);
                }
                else
                {
                    for (int wagon = 0; wagon < wagons.Count; wagon++)
                    {
                        if (wagons[wagon] + argumentOneInt <= maxWagonCapacity)
                        {
                            wagons[wagon] += argumentOneInt;
                            break;
                        }
                    }
                }
            }

            Console.WriteLine(string.Join(' ', wagons));

        }
    }
}