using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Articles_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int articlesCount = int.Parse(Console.ReadLine());

            List<Article> articlesList = new List<Article>();

            for (int i = 0; i < articlesCount; i++)
            {
                string[] input = Console.ReadLine().Split(", ");

                Article article = new Article();

                article.Title = input[0];
                article.Content = input[1];
                article.Author = input[2];

                articlesList.Add(article);
            }
            string orderBy = Console.ReadLine();

            if (orderBy == "title")
            {
                articlesList = articlesList.OrderBy(x => x.Title).ToList();
            }
            else if (orderBy == "content")
            {
                articlesList = articlesList.OrderBy(x => x.Content).ToList();
            }
            else if (orderBy == "author")
            {
                articlesList = articlesList.OrderBy(x => x.Author).ToList();
            }
            foreach (var articule in articlesList)
            {
                Console.WriteLine(articule.ToString());
            }
        }

    }
    class Article
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }
        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }
}
