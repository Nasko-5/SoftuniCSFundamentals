/* silly template */

// initialize inputs defined by problem


double[] validCoins = {1, 2, 0.5, 0.2, 0.1};
string coinInput = "";
double coin = 0;
double insertedMoney = 0;

string item = "";
Dictionary<string, double> itemPrices = new Dictionary<string, double>() {
    { "Nuts", 2.0 },
    { "Water", 0.7 },
    { "Crisps", 1.5 },
    { "Soda", 0.8 },
    { "Coke", 1.0 }
};

try
{
    // parse inputs from console
    while (true)
    {
        coinInput = Console.ReadLine();
        if (coinInput == "Start") { break; }
        coin = double.Parse(coinInput);
        if (validCoins.Contains(coin))
        {
            insertedMoney += coin;
        } else
        {
            Console.WriteLine($"Cannot accept {coin}");
        }
    }

    while (true)
    {
        item = Console.ReadLine();
        if (item == "End") 
        {
            Console.WriteLine($"Change: {insertedMoney:F2}");
            break;
        }

        if (itemPrices.ContainsKey(item))
        {
            if (insertedMoney >= itemPrices[item])
            {
                insertedMoney -= itemPrices[item];
                Console.WriteLine($"Purchased {item.ToLower()}");
            } else
            {
                Console.WriteLine("Sorry, not enough money");
            }
        } else
        {
            Console.WriteLine("Invalid product");
        }
    }

}
catch { Console.Error.WriteLine("Bad inputs! :("); Environment.Exit(1); }

// preform needed operation and print out result


Environment.Exit(0);