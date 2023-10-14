namespace _2.GaussTrick
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<double> numberList = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToList();

            for (int index = 0; index < numberList.Count / 2; index++)
            {
                //Console.WriteLine(index);
                double fromStart = numberList[index];
                double fromEnd = numberList[^(index+1)];
                Console.Write($"{fromStart + fromEnd} ");
            }

            if (numberList.Count % 2 != 0)
            {
                Console.WriteLine(numberList[numberList.Count/2]);
            }
        }
    }
}