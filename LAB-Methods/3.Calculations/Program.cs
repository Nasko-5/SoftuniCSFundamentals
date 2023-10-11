namespace _3.Calculations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            int numberOne = int.Parse(Console.ReadLine());
            int numberTwo = int.Parse(Console.ReadLine());

            switch (command)
            {
                case "add":
                    CalculatorAdd(numberOne, numberTwo);
                    break;
                case "subtract":
                    CalculatorSubtract(numberOne, numberTwo);
                    break;
                case "multiply":
                    CalculatorMultiply(numberOne, numberTwo);
                    break;
                case "divide":
                    CalculatorDivide(numberOne, numberTwo);
                    break;
                default:
                    Console.WriteLine("Invalid command!");
                    break;
            }
        }

        private static void CalculatorDivide(int numberOne, int numberTwo)
        {
            Console.WriteLine(numberOne / numberTwo);
        }

        private static void CalculatorMultiply(int numberOne, int numberTwo)
        {
            Console.WriteLine(numberOne * numberTwo);
        }

        private static void CalculatorSubtract(int numberOne, int numberTwo)
        {
            Console.WriteLine(numberOne - numberTwo);
        }

        private static void CalculatorAdd(int numberOne, int numberTwo)
        {
            Console.WriteLine(numberOne + numberTwo);
        }
    }
}