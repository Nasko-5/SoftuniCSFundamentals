/* silly template */


// parse inputs from console
int pokePower = int .Parse(Console.ReadLine());
int targetDistance = int .Parse(Console.ReadLine());
byte exhaustionFactor = byte .Parse(Console.ReadLine());

int initialPokePower = pokePower;
int pokeCount = 0;


while (targetDistance < pokePower)
{
    pokePower -= targetDistance;

    if (pokePower == initialPokePower / 2) {
        
        pokePower /= exhaustionFactor;
    }

    pokeCount++;
}

Console.WriteLine(pokePower);
Console.WriteLine(pokeCount);

// preform needed operation and print out result


Environment.Exit(0);