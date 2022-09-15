using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Articles {
    public class Article {
        public Article(string title, string content, string author) {
            Title = title;
            Content = content;
            Author = author;
        }

        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }
        


        public override string ToString() {
            return $"{Title} - {Content}: {Author}";
        }

    }
}
