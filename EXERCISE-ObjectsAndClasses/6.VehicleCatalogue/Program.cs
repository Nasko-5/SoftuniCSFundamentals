namespace _6.VehicleCatalogue
{
    class Vehicle
    {
        public string Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int Horsepower { get; set; }

        public Vehicle(string type, string model, string color, int horsepower)
        {
            Type = (char)(type[0] - 32) + type[1..];
            Model = model;
            Color = color;
            Horsepower = horsepower;
        }

        public override string ToString()
        {
            return $"Type: {Type}\n" +
                   $"Model: {Model}\n" +
                   $"Color: {Color}\n" +
                   $"Horsepower: {Horsepower}";
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            string[] splitInput;

            string type, model, color;
            int horsepower;

            List<Vehicle> carList = new List<Vehicle>();

            while((input = Console.ReadLine()) != "End")
            {
                splitInput = input.Split(' ');

                type = splitInput[0];
                model = splitInput[1];
                color = splitInput[2];
                horsepower = int.Parse(splitInput[3]);

                carList.Add(new Vehicle(type, model, color, horsepower));
            }

            Vehicle foundVehicle;

            while ((input = Console.ReadLine()) != "Close the Catalogue")
            {
                foundVehicle = carList.Find(vehicle => vehicle.Model == input);
                Console.WriteLine(foundVehicle);
            }

            var cars = carList.Where(vehicle => vehicle.Type == "Car").ToArray();
            var trucks = carList.Where(vehicle => vehicle.Type == "Truck").ToArray();

            double carHorsepowerAverage = cars.Average(car => car.Horsepower);
            double truckHorsepowerAverage = trucks.Average(truck => truck.Horsepower);

            Console.WriteLine($"Cars have average horsepower of: {carHorsepowerAverage:F2}.\n" +
                              $"Trucks have average horsepower of: {truckHorsepowerAverage:F2}.");
        }
    }
}