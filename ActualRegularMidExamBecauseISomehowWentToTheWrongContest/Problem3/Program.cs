using System.ComponentModel;

namespace Problem3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> cardsList = Console.ReadLine()
                .Split(", ")
                .ToList();

            int commandCount = int.Parse(Console.ReadLine());
            string command = "";
            List<string> arguments = new List<string>();

            for (int _ = 0; _ < commandCount; _++)
            {
                command = Console.ReadLine();
                arguments = command.Split(", ").ToList();
                command = arguments[0];
                arguments.RemoveAt(0);

                int indexArgument = 0;

                switch (command)
                {
                    case "Add":
                        if (!cardsList.Contains(arguments[0])) {
                            cardsList.Add(arguments[0]);
                            Console.WriteLine("Card successfully added");
                        } else
                        {
                            Console.WriteLine("Card is already in the deck");
                        }
                        break;
                    case "Remove":
                        if (cardsList.Contains(arguments[0]))
                        {
                            cardsList.Remove(arguments[0]);
                            Console.WriteLine("Card successfully removed");
                        } else
                        {
                            Console.WriteLine("Card not found");
                        }
                        break;
                    case "Remove At":
                        indexArgument = int.Parse(arguments[0]);

                        if (indexArgument >= 0 && indexArgument <= cardsList.Count-1)
                        {
                            cardsList.RemoveAt(indexArgument);
                            Console.WriteLine("Card successfully removed");
                        } else
                        {
                            Console.WriteLine("Index out of range");
                        }
                        break;
                    case "Insert":
                        indexArgument = int.Parse(arguments[0]);
                        if (indexArgument >= 0 && indexArgument <= cardsList.Count - 1)
                        {
                            if (!cardsList.Contains(arguments[1]))
                            {
                                cardsList.Insert(indexArgument, arguments[1]);
                                Console.WriteLine("Card successfully added");
                            } else
                            {
                                Console.WriteLine("Card is already added");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Index out of range");
                        }
                        break;
                }
            }
            Console.WriteLine(string.Join(", ", cardsList));
        }

    }
}