

namespace _3.HouseParty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int guestsToInvite = int.Parse(Console.ReadLine());
            List<string> guestList = new List<string>();

            List<string> statement;

            for (int i = 0; i < guestsToInvite; i++)
            {
                statement = Console.ReadLine().Split().ToList();

                string person = statement[0];

                if (statement.Contains("not"))
                {
                    if (guestList.Contains(person))
                    {
                        guestList.Remove(person);
                    }
                    else
                    {
                        Console.WriteLine($"{person} is not in the list!");
                    }
                }
                else
                {
                    if (guestList.Contains(person))
                    {
                        Console.WriteLine($"{person} is already in the list!");
                    }
                    else
                    {
                        guestList.Add(statement[0]);
                    }

                }
            }

            Console.WriteLine(string.Join('\n', guestList));
        }
    }
}