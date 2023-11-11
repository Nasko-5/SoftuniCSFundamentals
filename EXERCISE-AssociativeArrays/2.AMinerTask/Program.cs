namespace _2.AMinerTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string resource;
            int count;

            Dictionary<string, int> resourceCount = new Dictionary<string, int>();

            while ((resource = Console.ReadLine()) != "stop")
            {
                count = int.Parse(Console.ReadLine());
                
                if (!resourceCount.ContainsKey(resource))
                {
                    resourceCount[resource] = count;
                }
                else
                {
                    resourceCount[resource] += count;
                }
            }

            foreach (KeyValuePair<string, int> pair in resourceCount)
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value}");
            }
        }
    }
}