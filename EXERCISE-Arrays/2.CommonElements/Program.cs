string[] arrayOne = Console.ReadLine()
    .Split()
    .ToArray();

string[] arrayTwo = Console.ReadLine()
    .Split()
    .ToArray();

foreach (string element in arrayTwo)
{
    if (arrayOne.Contains(element))
    {
        Console.Write($"{element} ");
    }
}

/*

Hey hello 2 4
10 hey 4 hello

i love to code
code i love to

S of t un i
of i 10 un


 */

Console.WriteLine();