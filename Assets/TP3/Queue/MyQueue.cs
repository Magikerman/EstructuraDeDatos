using UnityEngine;

public class MyQueue<T>
{

    public int Count { get; private set; }
    private QueueNode<T> Head;
    private QueueNode<T> Tail;

    public MyQueue()
    {
        Count = 0;
        Head = new QueueNode<T>();
        Tail = Head;
    }
    public void Enqueue(T value)
    {
        if (Head.Equals(default))
        {
            Head.Value = value;
            Count++;
        }
        else
        {
            var newNode = new QueueNode<T>(value);
            Tail.Prev = newNode;
            newNode.Next = Tail;
            Tail = newNode;
            Count++;
        }
    }
    public T Dequeue()
    {
        T value = default;
        if (!Head.Value.Equals(default))
        {
            value = Head.Value;
            Head.Value = default;
            var tempHead = Head;
            Head = tempHead.Prev;
            tempHead.Prev = null;
            tempHead.Next = null;
            Head.Next = null;

            Count--;
        }
        return value;
    }
    public T Peek()
    {
        return Head.Value;
    }
    public void Clear()
    {
        for (int i = Count - 1; i < 0; i--)
        {
            Dequeue();
        }
        Head.Value = default;
        Tail = Head;
        Head.Prev = null;
        Head.Next = null;
        Count--;
    }

    public bool TryPeek(T value)
    {
        bool result = false;
        if (Head.Value.Equals(value))
        {
            result = true;
        }
        return result;
    }

    public bool TryDequeue(T value)
    {
        bool result = false;
        if (Head.Value.Equals(value))
        {
            Dequeue();
            result = true;
        }
        return result;
    }
}
