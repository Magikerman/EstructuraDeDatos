using System.Collections.Generic;

public class MyNode<T>
{
    public T Value;
    public MyNode<T> Prev;
    public MyNode<T> Next;


    public MyNode()
    {
        Value = default;
        Prev = null;
        Next = null;
    }
    public MyNode(T value)
    {
        Value = value;
        Prev = null;
        Next = null;
    }
    public MyNode(T value, MyNode<T> prev, MyNode<T> next)
    {
        Value = value;
        Prev = prev;
        Next = next;
    }

    public override string ToString()
    {
        return Value.ToString();
    }

    public bool Equals(T value)
    {
        return EqualityComparer<T>.Default.Equals(Value,value);
    }

}
