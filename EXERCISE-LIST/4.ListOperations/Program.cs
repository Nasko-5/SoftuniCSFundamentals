
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

            string command;

            List<string> argumentsList = new List<string>();


            while ((command = Console.ReadLine()) != null && command != "End")
            {
                argumentsList = command.Split(' ').ToList();
                string argumentOne = argumentsList.Count >= 2 ? argumentsList[1] : "0";
                int argumentOneInt = argumentOne.Any(char.IsDigit) ? int.Parse(argumentOne) : 0;

                int argumentTwo = argumentsList.Count == 3 ? int.Parse(argumentsList[2]) : 0;

                //Console.WriteLine($"{argumentOne} {argumentTwo}");

                switch (argumentsList[0])
                {
                    case "Remove":
                        if (argumentOneInt > inputList.Count) {
                            Console.WriteLine("Invalid index");
                            break;
                        }
                        inputList.RemoveAt(argumentOneInt);
                        break;
                    case "Insert":
                        if (argumentTwo > inputList.Count)
                        {
                            Console.WriteLine("Invalid index");
                            break;
                        }
                        inputList.Insert(argumentTwo, argumentOneInt);
                        break;

                    case "Add":
                        inputList.Add(argumentOneInt);
                        break;
                    case "Shift":
                        var shiftBy = argumentTwo % inputList.Count;
                        int[] holdingList = new int[shiftBy];

                        switch (argumentOne)
                        {
                            case "left":
                                inputList.CopyTo(0, holdingList, 0, shiftBy);
                                inputList.RemoveRange(0, shiftBy);
                                inputList.InsertRange(inputList.Count, holdingList);
                                break;
                            case "right":
                                inputList.CopyTo(inputList.Count - shiftBy, holdingList, 0, shiftBy);
                                inputList.RemoveRange(inputList.Count - shiftBy, shiftBy);
                                inputList.InsertRange(0, holdingList);
                                break;
                        }

                        break;
                }

                //Console.WriteLine("-> " + string.Join(' ', inputList));
            }

            Console.WriteLine(string.Join(' ', inputList));
        }
    }
}