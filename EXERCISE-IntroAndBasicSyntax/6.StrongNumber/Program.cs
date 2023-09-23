/* silly template */

int Factorial(int f)
{
    if (f == 0)
        return 1;
    else
        return f * Factorial(f - 1);
}

// initialize inputs defined by problem

string n = "";

try
{
    // parse inputs from console
    n = Console.ReadLine();
}
catch { Console.Error.WriteLine("Bad inputs! :("); Environment.Exit(1); }

// preform needed operation and print out result

int factorialSum = 0;
int currentNumber = 0;


foreach (char number in n)
{
    currentNumber = int.Parse(number.ToString());
    factorialSum += Factorial(currentNumber);
}

if (factorialSum == int.Parse(n))
{
    Console.WriteLine("yes");
}
else
{
    Console.WriteLine("no");
}


Environment.Exit(0);