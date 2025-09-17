using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StackNode<T>
{
    public T Value;
    public StackNode<T> Prev;

    public StackNode()
    {
        Value = default;
        Prev = null;
    }
    public StackNode(T value)
    {
        Value = value;
        Prev = null;
    }
    public StackNode(T value, StackNode<T> prev, StackNode<T> next)
    {
        Value = value;
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
