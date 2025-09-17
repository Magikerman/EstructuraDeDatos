using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QueueNode<T>
{
        public T Value;
        public QueueNode<T> Next;
        public QueueNode<T> Prev;

        public QueueNode()
        {
            Value = default;
            Prev = null;
            Next = null;
        }
        public QueueNode(T value)
        {
            Value = value;
            Prev = null;
            Next = null;
         
        }
        public QueueNode(T value, QueueNode<T> next, QueueNode<T> prev)
        {
            Value = value;
            Next = next;
            Prev = prev;
    }

        public override string ToString()
        {
            return Value.ToString();
        }

        public bool Equals(T value)
        {
            return EqualityComparer<T>.Default.Equals(Value, value);
        }
}
