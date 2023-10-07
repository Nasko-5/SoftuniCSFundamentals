
// define week day table
string[] daysOfWeek = new string[7]
{
    "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"
};

// get user input
float day = float.Parse(Console.ReadLine());


// try to index into array and print out the day
try 
{
    Console.WriteLine(daysOfWeek[(sbyte)day-1]);
} catch
{
    // if it fails, it means we've entered an invalid day
    Console.WriteLine("Invalid day!");
}