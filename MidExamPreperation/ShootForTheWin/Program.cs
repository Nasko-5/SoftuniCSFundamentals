using System.ComponentModel;
using System.Reflection;

namespace ShootForTheWin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> targets = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();


            string input;
            int shootAt;
            int targetValue = 0;

            while ((input = Console.ReadLine()) != "End")
            {
                shootAt = int.Parse(input);

                if (shootAt < 0 || shootAt >= targets.Count)
                {
                    continue;
                }

                targetValue = targets[shootAt];

                for (int target = 0; target < targets.Count; target++)
                {
                    if (targets[target] != -1)
                    {
                        if (targets[target] > targetValue)
                        {
                            targets[target] -= targetValue;
                        }
                        else
                        {
                            targets[target] += targetValue;
                        }
                    }
                }

                targets[shootAt] = -1;
            }

            Console.WriteLine($"Shot targets: {targets.Count(a => a == -1)} -> {string.Join(' ', targets)}");
        }
    }
}