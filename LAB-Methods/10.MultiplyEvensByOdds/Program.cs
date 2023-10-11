namespace _10.MultiplyEvensByOdds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = Math.Abs(int.Parse(Console.ReadLine()));
            int numberLength = (int)Math.Floor(Math.Log10(number) + 1);

            int sumEven = SumEvenNumbers(number, numberLength);
            int sumOdd = SumOddNumbers(number, numberLength);
            int product = sumEven * sumOdd;

            Console.WriteLine(product);
        }

        private static int SumEvenNumbers(int number, int numberLength)
        {
            int sum = 0;
            int lastNum = 0;

            for (int i = 0; i < numberLength; i++)
            {
                lastNum = number / (int)Math.Pow(10, i) % 10;

                if (lastNum % 2 == 0)
                {
                    sum += lastNum;
                }

            }

            return sum;
        }

        private static int SumOddNumbers(int number, int numberLength)
        {
            int sum = 0;
            int lastNum = 0;

            for (int i = 0; i < numberLength; i++)
            {
                lastNum = number / (int)Math.Pow(10, i) % 10;

                if (lastNum % 2 != 0)
                {
                    sum += lastNum;
                }

            }

            return sum;
        }
    }
}