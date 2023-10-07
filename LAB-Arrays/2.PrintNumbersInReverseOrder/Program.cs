

// read loop
uint readLines = uint.Parse(Console.ReadLine());
int[] numberList = new int[readLines];
for (int i = 0; i < readLines; i++)
{
    numberList[i] = int.Parse(Console.ReadLine());
}

// reverse and convert
string reversedList = string.Join(" ", numberList.Reverse());

// print
Console.WriteLine(reversedList);