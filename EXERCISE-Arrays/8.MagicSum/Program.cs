int[] numArray = Console.ReadLine()
    .Split(' ')
    .Select(int.Parse)
    .ToArray();


int targetSum = int.Parse(Console.ReadLine());
int n1, n2 = 0;

for (int i = 0; i < numArray.Length; i++)
{
    for (int j = 0; j < numArray.Length; j++)
    {
        n1 = numArray[i];
        n2 = numArray[j];
        if (n1 + n2 == targetSum && i < j)
        {

            Console.WriteLine($"{n1} {n2}");
// Console.WriteLine($"{n2} {n1}");
        }
    }
}