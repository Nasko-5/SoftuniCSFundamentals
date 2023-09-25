/* silly template */


/*
i've given up on this lmao

19.99
Reimen origin
RoverWatch
Zplinter Zell
Game Time


 */

// initialize inputs defined by problem

using System.Linq;

Dictionary<string, double> gamePrices = new Dictionary<string, double>()
{
    {                  "OutFall 4" , 39.99 },
    {                     "CS: OG" , 15.99 },
    {              "Zplinter Zell" , 19.99 },
    {                  "Honored 2" , 59.99 },
    {                 "RoverWatch" , 29.99 },
    { "RoverWatch Origins Edition" , 39.99 }
};

double money = 0.00f;
string boughtGame = "";

try
{
    // parse inputs from console
    money = double.Parse(Console.ReadLine());
}
catch { Console.Error.WriteLine("Bad inputs! :("); Environment.Exit(1); }

// preform needed operation and print out result

double moneySpent = 0;
double moneyLeft = money - moneySpent;
double gamePrice = 0;
 
while (true)
{
    if (moneyLeft <= 0)
    {
        Console.WriteLine("Out of money!");
        Environment.Exit(0);
    }

    boughtGame = Console.ReadLine();

    if (boughtGame == "Game Time") { break; }

    if (gamePrices.ContainsKey(boughtGame))
    {

        gamePrice = gamePrices[boughtGame];

        if (gamePrice <= moneyLeft)
        {
            Console.WriteLine($"Bought {boughtGame}");
            moneySpent += gamePrice;
            moneyLeft = money - moneySpent;
        }
        else if (gamePrice > moneyLeft) {
            Console.WriteLine("Too Expensive");
        }

    } else
    {
        Console.WriteLine("Not Found");
    }
}

moneySpent = Math.Round(moneySpent, 2);
moneyLeft = Math.Round(money - moneySpent, 2);

Console.WriteLine($"Total spent: ${moneySpent:F2}. Remaining: ${moneyLeft:F2}");

Environment.Exit(0);