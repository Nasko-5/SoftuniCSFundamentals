/* silly template */

// initialize inputs defined by problem

/*
 *  The table has a very simple structure, it's first index is the base number (0,1,2,3,4...)
 *  it indicates the set of characters to use! The second index is the amount of numbers (max 4 (but i dont rlly have a way of checking for that(wait actually i do, im just too lazy to implement it)))
 *  on the line, and that selects the character to use!
 */


char[,] letterArray = new char[,]
{
  {'a', 'b', 'c', ' '}, // 2
  {'d', 'e', 'f', ' '}, // 3
  {'g', 'h', 'i', ' '}, // 4
  {'j', 'k', 'l', ' '}, // 5
  {'m', 'n', 'o', ' '}, // 6
  {'p', 'q', 'r', 's'}, // 7
  {'t', 'u', 'v', ' '}, // 8
  {'w', 'x', 'y', 'z'}, // 9
  {' ', ' ', ' ', ' '}  // 0
};

char letter = ' ';
byte mainDigit = 0;
string input = "";
string output = "";

try
{
    // parse inputs from console
    while (true)
    {
        input = Console.ReadLine();

        if (input == "\n" || input == "" || input == null) { Console.WriteLine(); break; }

        mainDigit = byte.Parse(input[0].ToString());

        if (mainDigit != 1)
        {
            if (mainDigit == 0) { mainDigit = 10; }
            letter = letterArray[mainDigit-2, input.Length-1];
            output += letter;
        }
           
    }
}
catch (Exception e) { Console.Error.WriteLine($"Bad inputs! :(\n\n{e}"); Environment.Exit(1); }

    
// preform needed operation and print out result
Console.WriteLine($"\n{output}");

Environment.Exit(0);