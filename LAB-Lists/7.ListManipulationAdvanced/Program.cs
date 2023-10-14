/*

5 34 678 67 5 563 98
Contains 23
PrintOdd
GetSum
Filter >= 21
end
   


2 13 43 876 342 23 543
Contains 100
Contains 543
PrintEven
PrintOdd
GetSum
Filter >= 43
Filter < 100
end
   
 */


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

            List<string> argumentsList = new List<string>();

            bool changed = false;

            while ((command = Console.ReadLine()) != "end")
            {
                argumentsList = command.Split(' ').ToList();
                string argumentOne = argumentsList.Count >= 2 ? argumentsList[1] : "0";
                int argumentOneInt = argumentOne.Any(char.IsDigit) ? int.Parse(argumentOne) : 0;

                int argumentTwo = argumentsList.Count == 3 ? int.Parse(argumentsList[2]) : 0;

                //Console.WriteLine($"{argumentOne} {argumentTwo}");

                switch (argumentsList[0])
                {
                    case "Add":
                        inputList.Add(argumentOneInt);
                        changed = true;
                        break;
                    case "Remove":
                        inputList.Remove(argumentOneInt);
                        changed = true;
                        break;
                    case "RemoveAt":
                        inputList.RemoveAt(argumentOneInt);
                        changed = true;
                        break;
                    case "Insert":
                        inputList.Insert(argumentTwo, argumentOneInt);
                        changed = true;
                        break;
                    case "Contains":
                        Console.WriteLine(inputList.Contains(argumentOneInt) ? "Yes" : "No such number");
                        break;
                    case "PrintEven":
                        Console.WriteLine(string.Join(' ', inputList.Where(a => a % 2 == 0).ToList()));
                        break;
                    case "PrintOdd":
                        Console.WriteLine(string.Join(' ', inputList.Where(a => a % 2 != 0).ToList()));
                        break;
                    case "GetSum":
                        Console.WriteLine(inputList.Sum());
                        break;
                    case "Filter":
                        switch (argumentOne)
                        {
                            case "<":
                                Console.WriteLine(string.Join(' ', inputList.Where(a => a < argumentTwo).ToList()));
                                break;
                            case ">":
                                Console.WriteLine(string.Join(' ', inputList.Where(a => a > argumentTwo).ToList()));
                                break;
                            case "<=":
                                Console.WriteLine(string.Join(' ', inputList.Where(a => a <= argumentTwo).ToList()));
                                break;
                            case ">=":
                                Console.WriteLine(string.Join(' ', inputList.Where(a => a >= argumentTwo).ToList()));
                                break;
                        }
                        break;
                }
                //Console.WriteLine($"LS: {string.Join(' ', inputList)}\n");
            }

            Console.WriteLine(changed ? string.Join(' ', inputList) : "");
        }
    }
}