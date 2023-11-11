using System.ComponentModel;

namespace _5.TeamWorkProjects
{

    class Team
    {
        public string Owner { get; set; }
        public string Name { get; set; }
        public List<string> Members { get; set; }
    
        public Team(string owner, string name)
        {
            Name = name;
            Owner = owner;
            Members = new List<string>();
        }

        public override string ToString()
        {
            return $"{Name}\n" +
                   $"- {Owner}\n" +
                   $"{string.Join(Environment.NewLine, Members.OrderBy(name => name).Select(member => "-- " + member))}";
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Team> teams = new List<Team>();
            Team selectedTeam;

            int teamsToRegister = int.Parse(Console.ReadLine());
            string input, user, teamName = "";
            string[] splitInput;

            // here we get all the teams, we check if the user has already created the team, and that the team doesn't already exist

            for (int _ = 0; _ < teamsToRegister; _++)
            {
                splitInput = Console.ReadLine().Split('-');
                user = splitInput[0];
                teamName = splitInput[1];

                if (!teams.Exists(team => team.Owner == user))
                {
                    if (!teams.Exists(team => team.Name == teamName))
                    {
                        teams.Add(new Team(user, teamName));
                        Console.WriteLine($"Team {teamName} has been created by {user}!");
                    }
                    else
                    {
                        Console.WriteLine($"Team {teamName} was already created!");
                    }
                } else
                {
                    Console.WriteLine($"{user} cannot create another team!");
                }
            }   

            // here we get every user that joins!

            while ((input = Console.ReadLine()) != "end of assignment")
            {
                splitInput = input.Split("->");

                user = splitInput[0];
                teamName = splitInput[1];
                

                // DOES THE TEAM EXIST?
                if (teams.Exists(team => team.Name == teamName)) 
                {
                    if (!teams.Any(team => team.Owner == user) &&
                        !teams.Any(team => team.Members.Contains(user)))
                    {
                        teams.Find(team => team.Name == teamName).Members.Add(user);
                    } else
                    {
                        Console.WriteLine($"Member {user} cannot join team {teamName}!");
                    }


                } else
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                }
            }

            List<Team> teamsLeft = teams.Where(team => team.Members.Count > 0).ToList();

            teamsLeft = teamsLeft
                .OrderByDescending(t => t.Members.Count)
                .ThenBy(t => t.Name)
                .ToList();

            teamsLeft.ForEach(team => Console.WriteLine(team));

            List<Team> teamsDisbanded = teams.Where(team => team.Members.Count == 0).ToList();

            teamsDisbanded = teamsDisbanded.OrderBy(t => t.Name).ToList();

            Console.WriteLine("Teams to disband:");

            teamsDisbanded.ForEach(team => Console.WriteLine(team.Name));
        }


    }
}