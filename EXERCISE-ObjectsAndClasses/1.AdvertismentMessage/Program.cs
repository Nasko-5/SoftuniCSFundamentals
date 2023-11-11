namespace _1.AdvertismentMessage
{
    class Advertisement
    {
        public string[] Phrases { get; set; }
        public string[] Events { get; set; }
        public string[] Authors { get; set; }
        public string[] Cities { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Advertisement ad = new();
            Random random = new();

            ad.Phrases = new string[]
            {
                "Excellent product.", "Such a great product.", "I always use that product.",
                "Best product of its category.", "Exceptional product.", "I can't live without this product."
            };

            ad.Events = new string[]
            {
                "Now I feel good.", "I have succeeded with this product.",
                "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.",
                "Try it yourself, I am very satisfied.", "I feel great!"
            };

            ad.Authors = new string[] { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };

            ad.Cities = new string[] { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

            int messages = int.Parse(Console.ReadLine());

            for (int _ = 0; _ < messages; _++)
            {
                Console.WriteLine($"{ad.Phrases[random.Next(0, ad.Phrases.Length)]} " +
                                  $"{ad.Events[random.Next(0, ad.Events.Length)]} " +
                                  $"{ad.Authors[random.Next(0, ad.Authors.Length)]} - " +
                                  $"{ad.Cities[random.Next(0, ad.Cities.Length)]}.");
            }

        }
    }
}