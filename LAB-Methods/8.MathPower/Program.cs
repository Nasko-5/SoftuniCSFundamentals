namespace _8.MathPower
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double baseNumber = double.Parse(Console.ReadLine());
            double powerNumber = double.Parse(Console.ReadLine());

            double result = Math.Pow(baseNumber, powerNumber);

            Console.WriteLine(result);
        }
    }
}