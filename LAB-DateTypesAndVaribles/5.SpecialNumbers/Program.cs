/* silly template */

// initialize inputs defined by problem

int sumOfDigits (int number)
{
    string numString = number.ToString ();
    int sum = 0;
    int currentNumber = 0;

    foreach (char c in numString.ToCharArray ())
    {
        currentNumber = int.Parse(c.ToString());
        sum += currentNumber;
    }

    return sum;
}

int number = 0;
int sum = 0;

try
{
    // parse inputs from console
    number = int.Parse(Console.ReadLine());
}
catch { Console.Error.WriteLine("Bad inputs! :("); Environment.Exit(1); }

// preform needed operation and print out result


for (int i = 1; i <= number; i++)
{
    sum = sumOfDigits(i);
    Console.WriteLine($"{i} -> {(sum == 5 || sum == 7 || sum == 11 ? true : false)}");
}

Environment.Exit(0);