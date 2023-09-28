/* silly template */

// initialize inputs defined by problem

// π * r^2 * h
// Math.PI * Math.Pow(snowballSnow, 2) * snowballTime

// hehe im using things i cant understand yet because :333 
static (int snowballSnow, int snowballTime, int snowballQuality, double snowballValue) getSnowball()
{
    int snowballSnow = int.Parse(Console.ReadLine());
    int snowballTime = int.Parse(Console.ReadLine());
    int snowballQuality = int.Parse(Console.ReadLine());
    double snowballValue = Math.Pow((snowballSnow / snowballTime), snowballQuality);

    return (snowballSnow: snowballSnow, snowballTime: snowballTime, snowballQuality: snowballQuality, snowballValue: snowballValue);
}

// parse inputs from console
byte numberOfSnowBalls = byte.Parse(Console.ReadLine());

(int snowballSnow, int snowballTime, int snowballQuality, double snowballValue) bestSnowball = (0, 0, 0, 0);

// preform needed operation and print out result;
for (int i = 0; i < numberOfSnowBalls; i++)
{
    var newSnowball = getSnowball();

    //Console.WriteLine($"Looking at {newSnowball.snowballValue}");
    if (newSnowball.snowballValue > bestSnowball.snowballValue)
    
        //Console.WriteLine($"{newSnowball.snowballValue} > {bestSnowball.snowballValue}");
        bestSnowball = newSnowball;
    }}


// •	The output format is: 
// { snowballSnow} : { snowballTime} = { snowballValue} ({ snowballQuality})


Console.WriteLine($"{bestSnowball.snowballSnow} : {bestSnowball.snowballTime} = {bestSnowball.snowballValue} ({bestSnowball.snowballQuality})");

Environment.Exit(0);