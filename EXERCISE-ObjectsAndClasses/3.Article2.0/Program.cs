namespace _3.Article2._0
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

            public override string ToString()
            {
                return $"{Title} - {Content}: {Author}";
            }
        }

        internal class Program
        {
            static void Main(string[] args)
            {
                
                List<Article> articleList = new List<Article>();

                int numArticles = int.Parse(Console.ReadLine());
                string command = "";


                for (int _ = 0; _ < numArticles; _++)
                { 
                    string[] input = Console.ReadLine().Split(", ");

                    articleList.Add(new Article(input[0], input[1], input[2]));
                }

                Console.WriteLine(string.Join(Environment.NewLine, articleList.Select(a => a.ToString())));
            }
        }
    }