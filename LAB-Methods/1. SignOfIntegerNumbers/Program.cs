using System.ComponentModel.Design;

namespace _1._SignOfIntegerNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            switch (Math.Sign(number))
            {
                case 1: 
                    Console.WriteLine($"The number {number} is positive.");
                    break;
                default:
                    Console.WriteLine($"The number {number} is negative.");
                    break;
            }
        }
    }
}