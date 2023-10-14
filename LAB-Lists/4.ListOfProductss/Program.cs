namespace _4.ListOfProductss
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> productsList = new List<string>();

            int numberOfProducts = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfProducts; i++)
            {
                productsList.Add(Console.ReadLine());
            }

            productsList.Sort();
            List<string> numeratedProducts = productsList.Select((product, index) => $"{index+1}.{product}").ToList();

            Console.WriteLine(string.Join('\n', numeratedProducts));
        }
    }
}