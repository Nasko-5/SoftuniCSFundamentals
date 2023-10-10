// parse user input

int wagonNumber = int.Parse(Console.ReadLine());
int[] passengersInWagons = new int[wagonNumber];


for (int i = 0; i < wagonNumber; i++)
{
    passengersInWagons[i] = int.Parse(Console.ReadLine());
}

int totalPassengers = passengersInWagons.Sum();

Console.WriteLine($"{string.Join(' ', passengersInWagons)}\n" +
                  $"{totalPassengers}");