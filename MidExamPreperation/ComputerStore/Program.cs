string userInput = "";
decimal specialDiscount = 0.10m;
decimal regularTax = 0.20m;
decimal itemPrice = 0;
decimal price = 0;
decimal taxes = 0;
decimal total = 0;

while (true)
{
    userInput = Console.ReadLine();
    if (userInput == "regular" || userInput == "special")
    {
        break;
    }

    itemPrice = decimal.Parse(userInput);

    if (itemPrice < 0)
    {
        Console.WriteLine("Invalid price!");
        continue;
    }

    taxes += itemPrice * regularTax;
    price += itemPrice;
}

total = price + taxes;
total = userInput == "special" ? total - (total * specialDiscount) : total;

if (total == 0)
{
    Console.WriteLine("Invalid order!");
    return;
}

Console.WriteLine(
      "Congratulations you've just bought a new computer!\n"
    + $"Price without taxes: {price:F2}$\n"
    + $"Taxes: {taxes:F2}$\n"
    + $"-----------\n" 
    + $"Total price: {total:F2}$"
);



