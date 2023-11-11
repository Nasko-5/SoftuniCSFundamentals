namespace _1.ReverseStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> words = new List<string>();
            string input = "";
            char[] reversed;

            while ((input = Console.ReadLine()) != "end")
            {
                words.Add(input);
            }

            foreach (string word in words)
            {

                reversed = word.ToCharArray();
                Array.Reverse(reversed);
                Console.WriteLine($"{word} = {new string(reversed)}");
            }
             
        }
    }
}