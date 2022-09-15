using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomStack {
    public class CustomStack {
        private const int initialCapacity = 4;
        private int[] items;
        private int count;

        public CustomStack() {
            count = 0;
            items = new int[initialCapacity];
        }

        public int Count {
            get { return count; }
        }
        private void Resize() {
            int[] copy = new int[items.Length * 2];
            for (int i = 0; i < Count; i++) {
                copy[i] = items[i];
            }
        }
        public void Push(int element) {
            if (count == items.Length) {
                Resize();
            }
            items[count] = element;
            count++;
        }



        public int Pop() {
            if (items.Length == 0) {
                throw new InvalidOperationException();
            }
            int last  = items[count-1];

            count--;
            return last;
        }

        public int Peek() {
            if (items.Length == 0) {
                throw new InvalidOperationException();
            }

            return items[count - 1];
        }

        public void ForEach(Action<int> action) {
            for (int i = 0; i < count; i++) {
                action(items[i]);
            }
        }
    }
}
