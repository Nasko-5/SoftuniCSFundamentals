namespace Problem1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double budget = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double flourPrice = double.Parse(Console.ReadLine());
            double eggPrice = double.Parse(Console.ReadLine());
            double apronPrice = double.Parse(Console.ReadLine());

            double amountOfFlour = students - (double)Math.Ceiling((double)(students / 5));
            double amountOfEggs = students * 10;
            double amountOfAprons = Math.Ceiling(students + (students * 0.20));

            double total = (amountOfFlour * flourPrice) +
                           (amountOfEggs * eggPrice) +
                           (amountOfAprons * apronPrice);

            if (total <= budget)
            {
                Console.WriteLine($"Items purchased for {total:F2}$.");
            }
            else
            {
                Console.WriteLine($"{(total - budget):F2}$ more needed.");
            }
        }
    }
}