using System.Text;

namespace _3.TreasureFinder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] key = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            List<Resource> found = new List<Resource>();
            
            string toDecipher;
            string[] split;

            string mineral, coordinates;
            int coordStart, coordEnd;

            while ((toDecipher = Console.ReadLine()) != "find")
            {
                toDecipher = decode(key, toDecipher);
                split = toDecipher.Split('&');
                
                mineral = split[1];
                coordinates = split[^1];
                coordStart = coordinates.IndexOf('<') + 1;
                coordEnd = coordinates.IndexOf('>');
                coordinates = coordinates[coordStart..coordEnd];

                found.Add(new Resource(mineral, coordinates));
            }

            foreach (var resource in found)
            {
                Console.WriteLine(resource);
            }
        }

        static string decode(int[] key, string text)
        {
            StringBuilder decoded = new StringBuilder();

            for (int i = 0; i < text.Length; i++)
            {
                decoded.Append((char)(text[i] - key[i%key.Length]));
            }


            return decoded.ToString();
        }
    }

    class Resource
    {
        public string Mineral { get; set; }
        public string Coordinates { get; set; }

        public Resource(string mineral, string coordinates)
        {
            this.Mineral = mineral;
            this.Coordinates = coordinates;
        }

        public override string ToString()
        {
            return $"Found {Mineral} at {Coordinates}";
        }
    }
}