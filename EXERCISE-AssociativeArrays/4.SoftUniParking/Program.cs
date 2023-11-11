namespace _4.SoftUniParking
{
    internal class Program
    {

        static void Main(string[] args)
        {
            int commandCount = int.Parse(Console.ReadLine());

            string[] arguments;
            string username, liscencePlate;

            Dictionary<string, User> Users = new Dictionary<string, User>();


            for (int _ = 0; _ < commandCount; _++)
            {
                arguments = Console.ReadLine().Split(' ').ToArray();

                if (arguments[0] == "register")
                {
                    username = arguments[1];
                    liscencePlate = arguments[2];
                    if (!Users.ContainsKey(username))
                    {
                        Users.Add(username, new User(username, liscencePlate));
                        Console.WriteLine($"{username} registered {liscencePlate} successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {Users[username].LiscensePlate}");
                    }
                }
                else
                {
                    username = arguments[1];
                    if (Users.ContainsKey(username))
                    {
                        Users.Remove(username);
                        Console.WriteLine($"{username} unregistered successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: {username} not found");
                    }
                }
            }

            foreach (var user in Users)
            {
                Console.WriteLine(user.Value);
            }
        }

        class User
        {
            public string Username;
            public string LiscensePlate;

            public User(string username, string liscensePlate)
            {
                Username = username;
                LiscensePlate = liscensePlate;
            }

            public override string ToString()
            {
                return $"{Username} => {LiscensePlate}";
            }
        }
    }
}