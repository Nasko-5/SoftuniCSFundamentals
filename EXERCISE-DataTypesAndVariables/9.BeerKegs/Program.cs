/* silly template */

// initialize inputs defined by problem

// π * r^2 * h
// Math.PI * Math.Pow(radius, 2) * height

// hehe im using things i cant understand yet because :333 
static (string kegName, float radius, int height, double kegVolume) getKeg()
{
    string kegName = Console.ReadLine();
    float radius = float.Parse(Console.ReadLine());
    int height = int.Parse(Console.ReadLine());
    double kegVolume = Math.PI * Math.Pow(radius, 2) * height;

    return (kegName: kegName, radius: radius, height: height, kegVolume: kegVolume);
}

// parse inputs from console
byte numberOfKegs = byte.Parse(Console.ReadLine());

(string kegName, float radius, int height, double kegVolume) biggestKeg = ("", 0.00f, 0, 0);

// preform needed operation and print out result
for (int i = 0; i < numberOfKegs; i++)
{
    var newKeg = getKeg();

    if (newKeg.kegVolume > biggestKeg.kegVolume)
    {
        biggestKeg = newKeg;
    }}

Console.WriteLine(biggestKeg.kegName);

Environment.Exit(0);