int[] numArray = Console.ReadLine()
    .Split(' ')
    .Select(int.Parse)
    .ToArray();


for (int i = 0; i < numArray.Length; i++)
{
    // get all elements to the right of index i
    int[] sliced = numArray[i..];

    // get our top int
    int topInt = sliced[0];

    // sort array and reverse it so it is sorted from high to low
    Array.Sort(sliced);
    sliced = sliced.Reverse().ToArray();

    // then we get the index of our top int in the sorted and sliced array
    int isTopInt = Array.IndexOf(sliced, topInt);

    // if it is the first one, then it is the highest
    if (isTopInt == 0)
    {
        Console.Write($"{topInt} ");
    }
}