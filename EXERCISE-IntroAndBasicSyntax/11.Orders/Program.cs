/* silly template */

/*
 * test 1 - fail
 * test 2 - pass
 * test 3 - fail
 * test 4 - fail
 * test 5 - fail
 * test 6 - runtime error (for some reason??)
 */

// initialize inputs defined by problem
uint orderAmount = 0;
float capsulePrice = 0.00f;
byte days = 0;
short capsuleCount = 0;
double orderPrice = 0;
double total = 0;

try
{
    // parse inputs from console
    orderAmount = uint.Parse(Console.ReadLine());
    for (uint order = 1; order <= orderAmount; order++)
    {
        capsulePrice = float.Parse(Console.ReadLine());
        days = byte.Parse(Console.ReadLine());
        capsuleCount = short.Parse(Console.ReadLine());

        orderPrice = ((days * capsuleCount) * capsulePrice);
        total += orderPrice;
        Console.WriteLine($"The price for the coffee is: ${orderPrice:F2}");
    }
}
catch (Exception ex)
{
    Console.Error.WriteLine("An error occurred while processing the orders:");
    Console.Error.WriteLine(ex.Message);
    Environment.Exit(1);
}

// preform needed operation and print out result
Console.WriteLine($"Total: ${total:F2}");

Environment.Exit(0);