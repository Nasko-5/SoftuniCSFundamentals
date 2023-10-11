﻿namespace _11.MathOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            string @operator = Console.ReadLine();
            double b = double.Parse(Console.ReadLine());

            double result = Calculate(a, @operator, b);

            Console.WriteLine(result);
        }

        private static double Calculate(double a, string? @operator, double b)
        {
            double result = 0;

            switch (@operator)
            {
                case "+":
                    result = a + b;
                    break;
                case "-":
                    result = a - b;
                    break;
                case "*":
                    result = a * b;
                    break;
                case "/":
                    result = a / b;
                    break;
                default:
                    throw new NotImplementedException();
                    break;
            }

            return result;
        }
    }
}