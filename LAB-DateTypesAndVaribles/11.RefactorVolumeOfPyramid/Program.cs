

Console.WriteLine("Length: ");
double length = double.Parse(Console.ReadLine());

Console.WriteLine("Width: ");
double width = double.Parse(Console.ReadLine());

Console.WriteLine("Heigth: ");
double height = double.Parse(Console.ReadLine());

double volume = (length + width + height) / 3;
Console.WriteLine($"Pyramid Volume: {volume:f2}");
