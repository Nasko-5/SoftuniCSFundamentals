


namespace _02.ChangeList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> inputList = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            var argumentsList = new List<string>();

            string command = "";

            while ((command = Console.ReadLine()) != "end")
            {
                argumentsList = command.Split(' ').ToList();

                int argumentOne = int.Parse(argumentsList[1]);

                int argumentTwo = argumentsList.Count == 3 ? int.Parse(argumentsList[2]) : 0;

                switch (argumentsList[0])
                {
                    case "Delete":
                        inputList.RemoveAll(a => a == argumentOne);
                        break;
                    case "Insert":
                        inputList.Insert(argumentTwo, argumentOne);
                        break;
                }
            }

            Console.WriteLine(string.Join(' ', inputList));
        }
        }
}