using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxOfT {
    public class BoxOfT<T> {
        Stack<T> elements;

        public BoxOfT() {
            elements = new Stack<T>();
        }

        public int Count { get { return elements.Count; } }

        public void Add(T element) {
            elements.Push(element);
        }

        public T Remove() {
            return elements.Pop();
        }

    }
}
