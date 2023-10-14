/*
3 5 2 43 12 3 54 10 23
76 5 34 2 4 12


76 5 34 2 4 12
3 5 2 43 12 3 54 10 23
   

*/

namespace _4.ListOfProducts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> listOne = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            
            List<int> listTwo = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            List<int> outputList = new List<int>();

            int listOneSelector = 0;
            int listTwoSelector = 0;

            for (int index = 0; index < (listOne.Count >= listTwo.Count ? listOne.Count : listTwo.Count); index++)
            {
                listOneSelector = (index < listOne.Count ? listOne[index] : int.MinValue);
                listTwoSelector = (index < listTwo.Count ? listTwo[index] : int.MinValue);

                if (listOneSelector != int.MinValue)
                {
                    outputList.Add(listOneSelector);
                }

                if (listTwoSelector != int.MinValue)
                {
                    outputList.Add(listTwoSelector);
                }
            }

            Console.WriteLine(string.Join(' ', outputList));
        }
    }
}