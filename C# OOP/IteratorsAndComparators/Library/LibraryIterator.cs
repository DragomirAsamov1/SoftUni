using System.Collections;

namespace Library {
    class LibraryIterator : IEnumerator<Book> {
        private readonly List<Book> books;
        private int currentIndex;

        public LibraryIterator(IEnumerable<Book> books) {
            Reset();
            this.books = new List<Book>(books);
        }

        public Book Current => books[currentIndex];

        object IEnumerator.Current => Current;

        public void Dispose() { }

        public bool MoveNext() => ++currentIndex < books.Count;

        public void Reset() => currentIndex = -1;
    }
}