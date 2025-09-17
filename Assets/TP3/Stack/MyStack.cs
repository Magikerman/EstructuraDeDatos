using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyStack<T>
{

    public int Count { get; private set; }
    private StackNode<T> top;

    public MyStack()
    {
        Count = 0;
        top = null;
    }
    public void Push(T value)
    {
        if (top != null)
        {
            var newNode = new StackNode<T>(value);
            newNode.Prev = top;
            top = newNode;
            Count++;
        }
        else
        {
            top = new StackNode<T>(value);
            Count++;
        }

        //Preguntamos si el primero es null
        //Si es null, creamos uno nuevo y es el top
        //Si no, creamos uno nuevo, su prev es el top, y ahora el nuevo es el top
    }

    //Pop no puede ser void, tiene que devolver un elemento (T)
    //Variable temporal para el Value del top
    //Top = top.previous
    //Devuelven la variable temporal
    public T Pop()
    {
        T value = default;
        if (Count <= 1)
        {
            if (top != null)
            {
                value = top.Value;
            }
            top = null;
            Count = 0;
        }
        else
        {
            value = top.Value;
            top.Value = default;
            if (top.Prev != null)
            {
                top = top.Prev;
            }
            Count--;
        }
        return value;
    }
    public T Peek()
    {
        return top.Value;
    }

    //Pueden nullear el top, y el Garbage Collector borra todo el stack
    public void Clear()
    {
        Count = 0;
        top = null;
    }

    //Value tiene que ser out
    public bool TryPeek(T value)
    {
        //Para saber si esta vacio, preguntan si top == null
        //Ahi value es default, y retornan false
        //Si no, Value es el Value del top, y retornan true
        bool result = false;
        if (top.Value.Equals(value))
        {
            result = true;
        }
        return result;
    }

    //Igual que TryPeek, pero sacando el top
    public bool TryPop(T value)
    {
        bool result = false;
        if (top.Value.Equals(value))
        {
            Pop();
            result = true;
        }
        return result;
    }
}
