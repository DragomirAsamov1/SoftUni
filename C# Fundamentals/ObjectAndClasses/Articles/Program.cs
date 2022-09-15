using System;
using System.Collections.Generic;
using System.Linq;

namespace Articles {
    internal class Program {
        static void Main(string[] args) {

            int n = int.Parse(Console.ReadLine());

            List<Article> articles = new List<Article>();

            for (int i = 0; i < n; i++) {
                string[] input = Console.ReadLine().Split(", ");
                Article article = new Article(input[0], input[1], input[2]);
                articles.Add(article);
            }

            string orderCommand = Console.ReadLine();
            List<Article> sortedArticles = new List<Article>();
            if (orderCommand == "title") {
                sortedArticles = articles.OrderBy(x => x.Title).ToList();
            } else if (orderCommand == "content") {
                sortedArticles = articles.OrderBy(x => x.Content).ToList();
            } else if (orderCommand == "author") {
                sortedArticles = articles.OrderBy(x => x.Author).ToList();
            }

            Console.WriteLine(String.Join(Environment.NewLine, sortedArticles));
        }
    }
}
