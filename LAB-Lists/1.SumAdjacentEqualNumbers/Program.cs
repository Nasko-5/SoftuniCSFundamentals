namespace _1.SumAdjacentEqualNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<double> numList = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToList();

            for (int index = 0; index < numList.Count - 1; index++)
            {
                if (numList[index] == numList[index + 1])
                {
                    numList[index] += numList[index + 1];
                    numList.RemoveAt(index + 1);
                    index = -1;
                }
            }

            Console.WriteLine(string.Join(' ', numList));
        }
    }
}