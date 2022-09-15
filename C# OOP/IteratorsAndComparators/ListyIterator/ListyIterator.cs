using System.Collections;

namespace ListyIterator {
    public class ListyIterator<T> : IEnumerable<T> {
        private List<T> items;
        private int index;

        public ListyIterator(List<T> items) {
            this.items = items;
            this.index = 0;
        }

        public bool Move() {
            if (HasNext()) {
                index++;
                return true;
            }
            return false;
        }

        public bool HasNext() => index < items.Count - 1;

        public void Print() {
            if (index >= items.Count) {
                throw new InvalidOperationException();
            }
            Console.WriteLine(items[index]);
        }

        public IEnumerator<T> GetEnumerator() {
            foreach (T item in items) {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator() {
            return GetEnumerator();
        }
    }
}
