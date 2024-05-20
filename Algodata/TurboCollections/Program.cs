using System;
using System.Collections;
using System.Collections.Generic;

public class TurboLinkedStack<T> : IEnumerable<T> {
    class Node {
        public T Value;
        public Node Previous;
    }
    Node LastNode;

    public void Push(T item) {
        Node newNode = new Node { Value = item, Previous = LastNode };
        LastNode = newNode;
    }

    public T Peek() {
        if (LastNode == null) throw new InvalidOperationException("Stack is empty");
        return LastNode.Value;
    }

    public T Pop() {
        if (LastNode == null) throw new InvalidOperationException("Stack is empty");
        Node nodeToReturn = LastNode;
        LastNode = LastNode.Previous;
        return nodeToReturn.Value;
    }

    public void Clear() {
        LastNode = null;
    }

    public int Count {
        get {
            int count = 0;
            Node currentNode = LastNode;
            while (currentNode != null) {
                count++;
                currentNode = currentNode.Previous;
            }
            return count;
        }
    }

    public IEnumerator<T> GetEnumerator() {
        return new Enumerator(LastNode);
    }

    IEnumerator IEnumerable.GetEnumerator() {
        return GetEnumerator();
    }

    class Enumerator : IEnumerator<T> {
        private Node _currentNode;
        private Node _lastNode;

        public Enumerator(Node lastNode) {
            _lastNode = lastNode;
            _currentNode = null;
        }

        public bool MoveNext() {
            if (_currentNode == null) {
                _currentNode = _lastNode;
            } else {
                _currentNode = _currentNode.Previous;
            }
            return _currentNode != null;
        }

        public T Current {
            get {
                if (_currentNode == null) throw new InvalidOperationException();
                return _currentNode.Value;
            }
        }

        object IEnumerator.Current => Current;

        public void Reset() {
            _currentNode = null;
        }

        public void Dispose() {
            // No resources to dispose
        }
    }
}
