namespace _4.PrintingTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int triangleSize = int.Parse(Console.ReadLine());
            PrintTriangle(triangleSize);
        }

        static void PrintLine(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
        }

        static void PrintTriangle(int number)
        {
            
            for(int i = 0; i <= number; i++) 
            { 
                PrintLine(1, i);
            }

            for (int i = number - 1; i >= 1; i--)
            {
                PrintLine(1, i);
            }
                
        }
    }
}