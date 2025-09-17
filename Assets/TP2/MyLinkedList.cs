using System.Collections;
using System.Collections.Generic;

public class MyLinkedList<T> : ISimpleList<T>
{
    public T this[int index] 
    { 
      get 
      {
          var node = root;
          if (index > 0) { for (int i = 0; i < index; i++) { node = node.Next; } }
          return node.Value; 
      }
    }
    public int Count { get; private set; }

    //Campos:
    private MyNode<T> root;
    private MyNode<T> tail;
    //Funciones

    public MyLinkedList ()
    {
        root = new MyNode<T>(default);
        tail = root;
        Count = 0;
    }

    public void Add(T value)
    {
        if (root.Equals(default))
        {
            root.Value = value;
            Count++;
        }
        else 
        {
            var node = root.Next;
            var prevNode = root;
            for (int i = 0; i < Count; i++) 
            {
                if (node == null)
                {
                    node = new MyNode<T>(value);
                    tail = node;
                    node.Prev = prevNode;
                    prevNode.Next = node;
                    Count++;
                }
                else
                {
                    prevNode = node;
                    node = node.Next;
                }
            }
        }
    }
    public void AddRange(MyLinkedList<T> values)
    {
        //nidea
    }
    public void AddRange(T[] values) 
    {
        foreach (var e in values)
        {
            Add(e);
        }
    }
    public bool Remove(T value) 
    {
        bool removed = false;

        if (!root.Value.Equals(default))
        {
            var node = tail;

            for (int i = Count; i > 0; i--)
            {
                if (node.Equals(value))
                {
                    if (root == tail) { Clear();  break; }
                    if (node == tail) { tail = node.Prev;}
                    node.Prev.Next = node.Next;
                    if (node.Next != null) { node.Next.Prev = node.Prev; }

                    node.Prev = null;
                    node.Next = null;
                    node.Value = default;

                    Count--;
                    break;
                }
                else
                {
                    node = node.Prev;
                    if (node == root && node.Equals(value))
                    {
                        node.Next.Prev = null;
                        root = node.Next;
                        node.Next = null;
                        node.Value = default;
                        Count--;
                        break;
                    }
                }
            }
        }

        return removed;
    }
    public bool RemoveAt(int index) 
    {
        bool removed = false;
        if (index < Count)
        {
            if (root == tail) { Clear(); }
            var node = root;
            if (index > 0)
            {
                for (int i = 0; i < index; i++)
                {
                    node = node.Next;
                }
            }

            if (node == root) { root = node.Next; }
            if (node == tail) { tail = node.Prev; }

            if (node.Prev != null) { node.Prev.Next = node.Next; }
            if (node.Next != null) { node.Next.Prev = node.Prev; }

            node.Prev = null;
            node.Next = null;
            node.Value = default;

            Count--;
            removed = true;
        }
        return removed;
    }
    public void Insert(int index, T value) 
    {
        if (index < Count-1)
        {
            var node = root;
            if (index > 0) { for (int i = 0; i < index; i++) { node = node.Next; } }

            if (index == 0) { root = new MyNode<T>(value); root.Next = node; node.Prev = root; }

            var newNode = new MyNode<T>(value);
            node.Prev.Next = newNode;
            newNode.Prev = node.Prev;
            node.Prev = newNode;
            newNode.Next = node;
        }
        else if (index == Count)
        {
            var newNode = new MyNode<T>(value);
            newNode.Prev = tail;
            tail.Next = newNode;
        }
    }
    public bool IsEmpty() 
    {
        bool result = false;
        
        if (root == null)
        { result = true; }

        return result;
    }
    public void Clear() 
    {
        root.Value = default;
        root.Next = null;
        tail = root;
        Count = 0;
    }
}
