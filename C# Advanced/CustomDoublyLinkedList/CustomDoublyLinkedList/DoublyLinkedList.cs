﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomDoublyLinkedList {
    public class DoublyLinkedList {
        private class ListNode {
            public int Value { get; set; }
            public ListNode NextNode { get; set; }
            public ListNode PreviousNode { get; set; }
            public ListNode(int value) {
                Value = value;
            }
        }
        private ListNode head;
        private ListNode tail;

        public int Count { get; private set; }

        public void AddFirst(int element) {
            if (Count == 0) {
                head = tail = new ListNode(element);
            } else {
                ListNode newHead = new ListNode(element);
                newHead.NextNode = head;
                head.PreviousNode = newHead;
                head = newHead;
            }
            Count++;
        }

        public void AddLast(int element) {
            if (Count == 0) {
                tail = head = new ListNode(element);
            } else {
                ListNode newTail = new ListNode(element);
                newTail.PreviousNode = tail;
                tail.NextNode = newTail;
                tail = newTail;
            }
            Count++;
        }

        public int RemoveFirst() {
            if (Count == 0) {
                throw new InvalidOperationException("The list is empty");
            }

            int firstElement = head.Value;
            head = head.NextNode;
            if (head != null) {
                head.PreviousNode = null;
            } else {
                tail = null;
            }
            Count--;
            return firstElement;
        }

        public int RemoveLast() {
            if (Count == 0) {
                throw new InvalidOperationException("The list is empty");
            }

            int lastElement = tail.Value;
            tail = tail.PreviousNode;
            if (tail != null) {
                tail.NextNode = null;
            } else {
                head = null;
            }
            Count--;
            return lastElement;
        }

        public void ForEach(Action<int> action) {
            var currentNode = head;
            while (currentNode != null) {
                action(currentNode.Value);
                currentNode = currentNode.NextNode;
            }
        }

        public int[] ToArray() {
            int[] array = new int[Count];
            int counter = 0;
            var currentNode = head;
            while (currentNode != null) {
                array[counter] = currentNode.Value;
                currentNode = currentNode.NextNode;
                counter++;
            }
            return array;
        }

    }
}
