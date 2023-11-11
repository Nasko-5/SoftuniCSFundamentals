namespace _3.Songs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            List<Song> playlist = new List<Song>();


            for (int i = 0; i < lines; i++)
            {
                string[] tokens = Console.ReadLine().Split('_').ToArray();
                string listType = tokens[0];
                string songName = tokens[1];
                string songTime = tokens[2];

                Song song = new Song(listType, songName, songTime);
                
                playlist.Add(song);
            }

            string filter = Console.ReadLine();

            List<string> filteredSongs = playlist.Where(song => song.TypeList == filter | filter == "all").Select(song => song.Name).ToList();
            Console.WriteLine(string.Join(Environment.NewLine, filteredSongs));
        }
    }

    class Song
    {
        public string TypeList {get; set;}
        
        public string Name {get; set;}

        public string Time {get; set;}

        public Song(string type, string name, string time)
        {
            TypeList = type; Name = name; Time = time;
        }
    }
}   