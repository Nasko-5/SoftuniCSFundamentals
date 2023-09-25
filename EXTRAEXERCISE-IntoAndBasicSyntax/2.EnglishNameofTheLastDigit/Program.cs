/* silly template */

// initialize inputs defined by problem
int number = 0;
string[] numberTable = new string[10] {
    "zero","one","two","three","four","five","six","seven","eight","nine"
};

try
{
    // parse inputs from console
    number = int.Parse(Console.ReadLine());
}
catch { Console.Error.WriteLine("Bad inputs! :("); Environment.Exit(1); }

// preform needed operation and print out result
int lastNumber = number % 10;
Console.WriteLine(numberTable[lastNumber]);

Environment.Exit(0);