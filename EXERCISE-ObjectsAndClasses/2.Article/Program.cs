namespace _2.Article
{
    class Article
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        public Article(string title, string content, string author)
        {
            Title = title;
            Content = content;
            Author = author;
        }

        public void Edit(string content)
        {
            Content = content;
        }

        public void ChangeAuthor(string author)
        {
            Author = author;
        }

        public void Rename(string title)
        {
            Title = title;
        }

        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ");
            Article originalArticle = new Article(input[0], input[1], input[2]);

            int changes = int.Parse(Console.ReadLine());
            string command = "";


            for (int _ = 0; _ < changes; _++)
            {
                string[] arguments = Console.ReadLine().Split(": ");

                switch (arguments[0])
                {
                    case "Edit":
                        originalArticle.Edit(arguments[1]);
                        break;
                    case "ChangeAuthor":
                        originalArticle.ChangeAuthor(arguments[1]);
                        break;
                    case "Rename":
                        originalArticle.Rename(arguments[1]);
                        break;
                }
            }

            Console.WriteLine(originalArticle);
        }
    }
}