int kolkko = int.Parse(Console.ReadLine());
int sum = 0;
int takova = 0;
bool isSpeacialNum = false;
for (int ch = 1; ch <= kolkko; ch++)
{
    takova = ch;
    while (ch > 0)
    {
        sum += ch % 10;
        ch = ch / 10;
    }
    isSpeacialNum = (sum == 5) || (sum == 7) || (sum == 11);
    Console.WriteLine($"{takova} -> {isSpeacialNum}");
    sum = 0;
    ch = takova;
}

// lmao i give up, my solution to this was so much different 😭😭😭