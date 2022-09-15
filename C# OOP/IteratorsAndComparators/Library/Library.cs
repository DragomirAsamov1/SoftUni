using System.Collections;

namespace Library {
    public class Library : IEnumerable<Book> {
        private readonly List<Book> books;

        public Library(params Book[] books) {
            this.books = new List<Book>(books);
        }

        public Library() {
            books = new List<Book>();
        }

        public IEnumerator<Book> GetEnumerator() {

            //for (int i = 0; i < books.Count; i++) {
            //    yield return books[i];
            //}
            return new LibraryIterator(books);
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        public override string ToString() {
            return $"{string.Join(", ", books)}";
        }
    }
}
