namespace _6.ListManipulationBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> inputList = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string command;
            int argumentOne = 0;
            int argumentTwo = 0;
            List<string> argumentsList = new List<string>();

            while ((command = Console.ReadLine()) != "end")
            {
                argumentsList = command.Split(' ').ToList();
                argumentOne = int.Parse(argumentsList[1]);
                argumentTwo = argumentsList.Count == 3 ? int.Parse(argumentsList[2]) : 0;

                switch (argumentsList[0])
                {
                    case "Add":
                        inputList.Add(argumentOne);
                        break;
                    case "Remove":
                        inputList.Remove(argumentOne);
                        break;
                    case "RemoveAt":
                        inputList.RemoveAt(argumentOne);
                        break;
                    case "Insert":
                        inputList.Insert(argumentTwo, argumentOne);
                        break;
                }
                //Console.WriteLine($"LS: {string.Join(' ', inputList)}\n");
            }

            Console.WriteLine(string.Join(' ', inputList));
        }
    }
}