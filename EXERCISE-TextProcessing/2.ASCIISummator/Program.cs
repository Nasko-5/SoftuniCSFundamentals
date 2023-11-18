namespace _2.ASCIISummator
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int charOne = Console.ReadLine().ToCharArray()[0];
            int charTwo = Console.ReadLine().ToCharArray()[0];
            string randString = Console.ReadLine();
   
            var range = Enumerable.Range(charOne, charTwo);

            int sum = 0;

            foreach (char c in range)
            {
                if (randString.Contains(c))
                {
                    sum += randString.Count(a => a == c) * c;
                }
            }

            Console.WriteLine(sum);
        }
    }
}