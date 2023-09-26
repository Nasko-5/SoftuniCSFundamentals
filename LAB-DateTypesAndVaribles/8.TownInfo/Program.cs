/* silly template */

// initialize inputs defined by problem


string town = "";
uint population = 0;
uint area = 0;


try
{
    // parse inputs from console
    town = Console.ReadLine();
    population = uint.Parse(Console.ReadLine());
    area = uint.Parse(Console.ReadLine());

}
catch { Console.Error.WriteLine("Bad inputs! :("); Environment.Exit(1); }

// preform needed operation and print out result

//"Town {town name} has population of {population} and area {area} square km".
Console.WriteLine($"Town {town} has population of {population} and area {area} square km.");

Environment.Exit(0);