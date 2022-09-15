namespace CustomLinkedList {
    public class CustomList<T> {
        private const int InitialCapacity = 2;
        private T[] items;

        public CustomList() {
            items = new T[InitialCapacity];
        }

        public int Count { get; private set; }
        public T this[int index] {
            get {
                if (index >= Count) {
                    throw new ArgumentOutOfRangeException();
                }
                return items[index];
            }
            set {
                if (index >= Count) {
                    throw new ArgumentOutOfRangeException();
                }
                items[index] = value;
            }
        }

        private void Resize() {
            T[] copy = new T[items.Length * 2];
            for (int i = 0; i < items.Length; i++) {
                copy[i] = items[i];
            }
            items = copy;
        }

        public void Add(T item) {
            if (Count == items.Length) {
                Resize();
            }
            items[Count] = item;
            Count++;
        }

        private void Shift(int index) {
            for (int i = Count; i < Count - 1; i++) {
                items[i] = items[i + 1];
            }
        }

        private void Shrink() {
            T[] copy = new T[items.Length / 2];
            for (int i = 0; i < items.Length; i++) {
                copy[i] = items[i];
            }
            items = copy;
        }

        public T RemoveAt(int index) {
            if (index >= Count) {
                throw new ArgumentOutOfRangeException();
            }

            T item = items[index];
            items[index] = default(T);
            Shift(index);
            Count--;
            if (Count <= items.Length / 4) {
                Shrink();
            }
            return item;
        }

        private void ShiftToRight(int index) {
            for (int i = Count; i > 0; i--) {
                items[i] = items[i - 1];
            }
        }

        public void Insert(int index, T item) {
            if (index > Count) {
                throw new ArgumentOutOfRangeException();
            }

            if (Count == items.Length) {
                Resize();
            }

            ShiftToRight(index);

            items[index] = item;
            Count++;
        }

        public bool Contains(T item) {
            for (int i = 0; i < Count; i++) {
                if (items[i].Equals(item)) {
                    return true;
                }
            }
            return false;
        }

        public void Swap(int firstIndex, int secondIndex) {
            if (firstIndex >= Count || secondIndex >= Count) {
                throw new ArgumentOutOfRangeException();
            }
            T temp = items[firstIndex];
            items[firstIndex] = items[secondIndex];
            items[secondIndex] = temp;
        }
    }
}
