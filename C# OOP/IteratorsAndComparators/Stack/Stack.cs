﻿using System;
using System.Collections;
using System.Collections.Generic;

namespace Stack {
    public class Stack<T> : IEnumerable<T> {
        private List<T> items;

        public Stack() {
            items = new List<T>();
        }

        public Stack(List<T> items) {
            this.items = items;
        }

        public void Push(T item) {
            items.Add(item);
        }

        public T Pop() {
            if (items.Count == 0) {
                throw new ArgumentOutOfRangeException("No elements");
            }
            int index = items.Count - 1;
            T item = items[index];
            items.RemoveAt(index);
            return item;
        }
        public IEnumerator<T> GetEnumerator() {
            for (int i = items.Count - 1; i >= 0; i--) {
                yield return items[i];
            }
            
        }

        IEnumerator IEnumerable.GetEnumerator() {
            return GetEnumerator();
        }

    }
}
