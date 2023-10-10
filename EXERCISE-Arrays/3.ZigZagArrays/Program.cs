int pairs = int.Parse(Console.ReadLine());
int[] pair = new int[2];

int[] arrayOne = new int[pairs];
int[] arrayTwo = new int[pairs];
bool zigZag = true;

for (int i = 0; i < pairs; i++)
{
    pair = Console.ReadLine()
        .Split()
        .Select(int.Parse)
        .ToArray();

    arrayOne[i] = pair[Convert.ToInt32(!zigZag)];
    arrayTwo[i] = pair[Convert.ToInt32(zigZag)];

    zigZag = !zigZag;
}


Console.WriteLine($"{string.Join(' ', arrayOne)}\n" +
                  $"{string.Join(' ', arrayTwo)}");