int[] numberArray =  Console.ReadLine()
    .Split(" ")
    .Select(int.Parse)
    .ToArray();

int rotations =  int.Parse(Console.ReadLine());

if (rotations > numberArray.Length)
{
    return;
}

int[] holdingArray = new int[rotations];


for (int i = 0; i < rotations; i++)
{
    holdingArray[i] = numberArray[i];
}

for (int i = rotations; i < numberArray.Length; i++)
{
    numberArray[i - rotations] = numberArray[i];
}

for (int i = 0; i < rotations; i++)
{
    numberArray[numberArray.Length - rotations + i] = holdingArray[i];
}

Console.WriteLine(string.Join(' ', numberArray));